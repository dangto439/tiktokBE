using _3.DAL.Entity;

namespace _2.BLL.Interface
{
    public interface IUser
    {
        // Thêm một user mới
        Task AddUserAsync(User user);

        // Cập nhật thông tin của user
        Task UpdateUserAsync(User user);

        // Xóa user theo Id
        Task DeleteUserAsync(int userId);

        // Lấy thông tin user theo Id
        Task<User> GetUserByIdAsync(int userId);

        // Lấy tất cả user
        Task<List<User>> GetAllUsersAsync();

        // Tìm kiếm user theo tên
        Task<object> SearchUsersByNameAsync(string name, string type, int page);
    }
}
