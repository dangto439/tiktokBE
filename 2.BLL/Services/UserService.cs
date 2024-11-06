using _2.BLL.Interface;
using _3.DAL.Entity;
using _3.DAL.Repositories;
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

        public async Task<object> SearchUsersByNameAsync(string name, string type)
        {
            int page = 1;  // Bạn có thể thay đổi trang từ phía người dùng (thêm tham số `page` nếu cần).
            var pageSize = 10;  // Kích thước mỗi trang cho trường hợp 'more'

            // Lấy tất cả người dùng
            var allUsers = await _userRepository.GetAllUsersAsync();

            // Chuẩn hóa tên tìm kiếm và tên người dùng (bỏ dấu, bỏ cách)
            string normalizedSearchName = RemoveSpaces(RemoveDiacritics(name.ToLower()));

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
                int totalUsers = filteredUsers.Count;  // Tổng số người dùng sau khi lọc
                int totalPages = (int)Math.Ceiling(totalUsers / (double)pageSize);  // Tổng số trang

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

            // Trường hợp type không hợp lệ, trả về danh sách trống
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
