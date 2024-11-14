using _2.BLL.Interface;
using _3.DAL.Entity;
using _3.DAL.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.Text;

namespace _2.BLL.Services
{
    public class UserService : IUser
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task AddUserAsync(User user)
        {
            await _userRepository.AddUserAsync(user);
        }

        public async Task DeleteUserAsync(int userId)
        {
            await _userRepository.DeleteUserAsync(userId);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _userRepository.GetUserByIdAsync(userId);
        }

        public async Task<object> SearchUsersByNameAsync(string name, string type, int page)
        {
             // Có thể điều chỉnh trang từ phía người dùng bằng cách thêm tham số `page`
            var pageSize = 10;  // Kích thước mỗi trang cho trường hợp 'more'

            // Lấy tất cả người dùng
            var allUsers = await _userRepository.GetAllUsersAsync();

            // Trường hợp nếu `name` để trống và `type` là "more", trả về toàn bộ danh sách với phân trang
            if (string.IsNullOrEmpty(name) && type == "more")
            {
                int totalUsers = allUsers.Count;
                int totalPages = (int)Math.Ceiling(totalUsers / (double)pageSize);

                var pagedUsers = allUsers
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                return new
                {
                    data = pagedUsers,
                    pagination = new
                    {
                        currentPage = page,
                        totalPages = totalPages,
                        totalUsers = totalUsers
                    }
                };
            }

            // Chuẩn hóa tên tìm kiếm và tên người dùng nếu `name` có giá trị
            string normalizedSearchName = RemoveSpaces(RemoveDiacritics(name?.ToLower() ?? string.Empty));

            // Lọc người dùng theo tên
            var filteredUsers = allUsers.FindAll(user =>
                RemoveSpaces(RemoveDiacritics(user.FullName.ToLower())).Contains(normalizedSearchName));

            // Trường hợp 'less' - chỉ lấy tối đa 5 kết quả
            if (type == "less")
            {
                return filteredUsers.Take(5).ToList();
            }
            // Trường hợp 'more' - phân trang với 10 kết quả mỗi trang
            else if (type == "more")
            {
                int totalUsers = filteredUsers.Count;
                int totalPages = (int)Math.Ceiling(totalUsers / (double)pageSize);

                var pagedUsers = filteredUsers
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                return new
                {
                    data = pagedUsers,
                    pagination = new
                    {
                        currentPage = page,
                        totalPages = totalPages,
                        totalUsers = totalUsers
                    }
                };
            }

            // Trường hợp `type` không hợp lệ, trả về danh sách trống
            return new List<User>();
        }





        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateUserAsync(user);
        }


        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            foreach (var c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public static string RemoveSpaces(string text)
        {
            return text.Replace(" ", "");
        }
    }
}
