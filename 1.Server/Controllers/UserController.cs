using _2.BLL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace _1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userService;

        public UserController(IUser userService)
        {
            _userService = userService;
        }

        // Endpoint để tìm kiếm người dùng theo tên và phân trang nếu cần
        [HttpGet("search")]
        public async Task<IActionResult> SearchUsersByName(
        [FromQuery] string? name, 
        [FromQuery] string type = "less",
        [FromQuery] int page =1)
        {
            // Kiểm tra nếu `type` không hợp lệ
            if (type != "less" && type != "more")
            {
                return BadRequest("Type must be either 'less' or 'more'.");
            }

            // Gọi dịch vụ tìm kiếm người dùng
            var users = await _userService.SearchUsersByNameAsync(name ?? string.Empty, type, page);
            return Ok(users);
        }


        [HttpGet("testCICD")]
        public string TestCICD()
        {
            return "CI/CD successfully";
        }
    }
}
