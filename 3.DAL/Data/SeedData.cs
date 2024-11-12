using _3.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace _3.DAL.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(TiktokDbContext context)
        {
            if (context.Users.Any())
            {
                // Dữ liệu đã tồn tại, không cần thêm lại
                return;
            }

            var users = new List<User>
            {
                new User
                {
                    FirstName = "Đào Lê",
                    LastName = "Phương Hoa",
                    FullName = "Đào Lê Phương Hoa",
                    Nickname = "hoaahanassii",
                    Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRLfDcQsdmXFOrlxpFlwdJqmRE_TN4RmZRN4A&s",
                    Bio = "✨ 1998 ✨\nVietnam 🇻🇳\nĐỪNG LẤY VIDEO CỦA TÔI ĐI SO SÁNH NỮA. XIN HÃY TÔN TRỌNG !",
                    Tick = true,
                    FollowingsCount = 1,
                    FollowersCount = 83,
                    LikesCount = 1000,
                    CreatedAt = DateTime.Parse("2022-05-05 23:10:05"),
                    UpdatedAt = DateTime.Parse("2022-05-05 23:11:39")
                },
                new User
            {
                FirstName = "Nguyễn Thị",
                LastName = "Lan Anh",
                FullName = "Nguyễn Thị Lan Anh",
                Nickname = "nguyenthlananh",
                Avatar = "https://example.com/avatar1.jpg",
                Bio = "Chào các bạn! Cùng nhau học hỏi và trưởng thành nhé! 💕",
                Tick = true,
                FollowingsCount = 500,
                FollowersCount = 10000,
                LikesCount = 50000,
                CreatedAt = DateTime.Parse("2023-06-01 12:00:00"),
                UpdatedAt = DateTime.Parse("2023-06-01 12:10:00")
            },
            new User
            {
                FirstName = "Trần",
                LastName = "Thái Hòa",
                FullName = "Trần Thái Hòa",
                Nickname = "thanhhoa_tran",
                Avatar = "https://example.com/avatar2.jpg",
                Bio = "Tìm niềm vui trong từng khoảnh khắc của cuộc sống 😎",
                Tick = false,
                FollowingsCount = 200,
                FollowersCount = 4500,
                LikesCount = 25000,
                CreatedAt = DateTime.Parse("2023-07-12 14:20:35"),
                UpdatedAt = DateTime.Parse("2023-07-12 14:30:10")
            },
            new User
            {
                FirstName = "Lê",
                LastName = "Thị Lan",
                FullName = "Lê Thị Lan",
                Nickname = "lanle_tiktok",
                Avatar = "https://example.com/avatar3.jpg",
                Bio = "Nơi chia sẻ những video vui vẻ và đầy cảm hứng 🎥✨",
                Tick = true,
                FollowingsCount = 1500,
                FollowersCount = 12000,
                LikesCount = 80000,
                CreatedAt = DateTime.Parse("2022-09-15 17:25:45"),
                UpdatedAt = DateTime.Parse("2022-09-15 17:30:00")
            },
            new User
            {
                FirstName = "Phạm",
                LastName = "Quốc Anh",
                FullName = "Phạm Quốc Anh",
                Nickname = "quocanh_pham",
                Avatar = "https://example.com/avatar4.jpg",
                Bio = "Lướt TikTok và tận hưởng những giây phút thư giãn! 🌟",
                Tick = true,
                FollowingsCount = 700,
                FollowersCount = 14000,
                LikesCount = 65000,
                CreatedAt = DateTime.Parse("2023-01-20 10:15:30"),
                UpdatedAt = DateTime.Parse("2023-01-20 10:20:00")
            },
            new User
            {
                FirstName = "Mai",
                LastName = "Tấn Tài",
                FullName = "Mai Tấn Tài",
                Nickname = "maitantai_official",
                Avatar = "https://example.com/avatar5.jpg",
                Bio = "Khám phá những điều mới lạ cùng mình nhé! 🔥",
                Tick = false,
                FollowingsCount = 1200,
                FollowersCount = 5000,
                LikesCount = 10000,
                CreatedAt = DateTime.Parse("2023-03-01 16:50:50"),
                UpdatedAt = DateTime.Parse("2023-03-01 16:55:20")
            },
            new User
            {
                FirstName = "Hồ",
                LastName = "Thiên Kim",
                FullName = "Hồ Thiên Kim",
                Nickname = "thienkim_hovo",
                Avatar = "https://example.com/avatar6.jpg",
                Bio = "Cuộc sống là những chuyến đi, cùng tôi trải nghiệm nhé 🌈",
                Tick = true,
                FollowingsCount = 350,
                FollowersCount = 9500,
                LikesCount = 55000,
                CreatedAt = DateTime.Parse("2022-11-10 18:40:25"),
                UpdatedAt = DateTime.Parse("2022-11-10 18:45:15")
            },
            new User
            {
                FirstName = "Lý",
                LastName = "Bảo Trân",
                FullName = "Lý Bảo Trân",
                Nickname = "baotran_ly",
                Avatar = "https://example.com/avatar7.jpg",
                Bio = "Nữ hoàng TikTok 🔥 Follow để cùng khám phá thế giới này!",
                Tick = true,
                FollowingsCount = 850,
                FollowersCount = 20000,
                LikesCount = 100000,
                CreatedAt = DateTime.Parse("2023-04-25 11:55:10"),
                UpdatedAt = DateTime.Parse("2023-04-25 12:00:05")
            },
            new User
            {
                FirstName = "Trương",
                LastName = "Mai Hương",
                FullName = "Trương Mai Hương",
                Nickname = "maihuong_truong",
                Avatar = "https://example.com/avatar8.jpg",
                Bio = "Sự nghiệp TikTok của tôi bắt đầu từ đam mê 💖",
                Tick = false,
                FollowingsCount = 1000,
                FollowersCount = 11000,
                LikesCount = 45000,
                CreatedAt = DateTime.Parse("2022-06-10 08:30:45"),
                UpdatedAt = DateTime.Parse("2022-06-10 08:35:20")
            },
            new User
            {
                FirstName = "Vũ",
                LastName = "Thị Mai",
                FullName = "Vũ Thị Mai",
                Nickname = "vthimai",
                Avatar = "https://example.com/avatar9.jpg",
                Bio = "Cùng nhau tạo nên những video TikTok cực chất 💥",
                Tick = true,
                FollowingsCount = 650,
                FollowersCount = 16000,
                LikesCount = 70000,
                CreatedAt = DateTime.Parse("2023-02-28 09:15:00"),
                UpdatedAt = DateTime.Parse("2023-02-28 09:20:15")
            },
            new User
            {
                FirstName = "Nguyễn",
                LastName = "Quang Minh",
                FullName = "Nguyễn Quang Minh",
                Nickname = "quangminh_nguyen",
                Avatar = "https://example.com/avatar10.jpg",
                Bio = "Đam mê sáng tạo và chia sẻ mọi khoảnh khắc vui vẻ! 🎉",
                Tick = false,
                FollowingsCount = 400,
                FollowersCount = 8000,
                LikesCount = 15000,
                CreatedAt = DateTime.Parse("2022-12-10 15:50:20"),
                UpdatedAt = DateTime.Parse("2022-12-10 15:55:50")
            },
            new User
            {
                FirstName = "Đỗ",
                LastName = "Ngọc Anh",
                FullName = "Đỗ Ngọc Anh",
                Nickname = "ngocanh_do",
                Avatar = "https://example.com/avatar11.jpg",
                Bio = "TikTok là nơi tôi thể hiện bản thân 💃",
                Tick = true,
                FollowingsCount = 1200,
                FollowersCount = 18000,
                LikesCount = 90000,
                CreatedAt = DateTime.Parse("2023-05-18 19:40:00"),
                UpdatedAt = DateTime.Parse("2023-05-18 19:45:00")
            },
            new User
            {
                FirstName = "Lương",
                LastName = "Quốc Duy",
                FullName = "Lương Quốc Duy",
                Nickname = "quocduy_luong",
                Avatar = "https://example.com/avatar12.jpg",
                Bio = "Chào các bạn, mình là Duy và đây là hành trình TikTok của tôi!",
                Tick = false,
                FollowingsCount = 500,
                FollowersCount = 6500,
                LikesCount = 30000,
                CreatedAt = DateTime.Parse("2023-07-09 16:00:00"),
                UpdatedAt = DateTime.Parse("2023-07-09 16:05:00")
            },
            new User
            {
                FirstName = "Hạ",
                LastName = "Minh Tuấn",
                FullName = "Hạ Minh Tuấn",
                Nickname = "minhtuan_ha",
                Avatar = "https://example.com/avatar13.jpg",
                Bio = "Khám phá thế giới cùng tôi qua những video TikTok 📽️",
                Tick = true,
                FollowingsCount = 800,
                FollowersCount = 22000,
                LikesCount = 120000,
                CreatedAt = DateTime.Parse("2023-02-21 18:45:30"),
                UpdatedAt = DateTime.Parse("2023-02-21 18:50:00")
            },
            new User
            {
                FirstName = "Phan",
                LastName = "Bảo Vân",
                FullName = "Phan Bảo Vân",
                Nickname = "baovan_phan",
                Avatar = "https://example.com/avatar14.jpg",
                Bio = "Sống là phải đam mê, sống là phải cống hiến! ✨",
                Tick = true,
                FollowingsCount = 300,
                FollowersCount = 5000,
                LikesCount = 25000,
                CreatedAt = DateTime.Parse("2022-05-23 10:35:40"),
                UpdatedAt = DateTime.Parse("2022-05-23 10:40:10")
            },
            new User
            {
                FirstName = "Bùi",
                LastName = "Mỹ Lan",
                FullName = "Bùi Mỹ Lan",
                Nickname = "mylan_bui",
                Avatar = "https://example.com/avatar15.jpg",
                Bio = "Video vui, thú vị và hài hước ở đây! 🎉",
                Tick = false,
                FollowingsCount = 150,
                FollowersCount = 3000,
                LikesCount = 9000,
                CreatedAt = DateTime.Parse("2023-03-12 09:00:00"),
                UpdatedAt = DateTime.Parse("2023-03-12 09:05:00")
            },
            new User
            {
                FirstName = "Phan",
                LastName = "Trí Quang",
                FullName = "Phan Trí Quang",
                Nickname = "triquang_phan",
                Avatar = "https://example.com/avatar16.jpg",
                Bio = "Không có gì là không thể nếu bạn dám thử! 💪",
                Tick = true,
                FollowingsCount = 900,
                FollowersCount = 24000,
                LikesCount = 110000,
                CreatedAt = DateTime.Parse("2023-02-05 13:30:40"),
                UpdatedAt = DateTime.Parse("2023-02-05 13:35:10")
            },
            new User
            {
                FirstName = "Đỗ",
                LastName = "Thị Thanh",
                FullName = "Đỗ Thị Thanh",
                Nickname = "thithanh_do",
                Avatar = "https://example.com/avatar17.jpg",
                Bio = "Chia sẻ niềm vui, trải nghiệm cuộc sống! 🌸",
                Tick = true,
                FollowingsCount = 400,
                FollowersCount = 8000,
                LikesCount = 32000,
                CreatedAt = DateTime.Parse("2022-11-30 14:25:00"),
                UpdatedAt = DateTime.Parse("2022-11-30 14:30:10")
            },
            new User
            {
                FirstName = "Lý",
                LastName = "Hoàng Nam",
                FullName = "Lý Hoàng Nam",
                Nickname = "hoangnam_ly",
                Avatar = "https://example.com/avatar18.jpg",
                Bio = "Bản thân là nhất! 🔥 Follow để khám phá điều thú vị nhé!",
                Tick = true,
                FollowingsCount = 800,
                FollowersCount = 18000,
                LikesCount = 75000,
                CreatedAt = DateTime.Parse("2023-06-14 12:20:00"),
                UpdatedAt = DateTime.Parse("2023-06-14 12:25:00")
            },
            new User
            {
                FirstName = "Nguyễn",
                LastName = "Thiện Nhân",
                FullName = "Nguyễn Thiện Nhân",
                Nickname = "thiennhan_nguyen",
                Avatar = "https://example.com/avatar19.jpg",
                Bio = "Sáng tạo không ngừng nghỉ 💥",
                Tick = false,
                FollowingsCount = 350,
                FollowersCount = 5000,
                LikesCount = 15000,
                CreatedAt = DateTime.Parse("2023-08-10 10:40:30"),
                UpdatedAt = DateTime.Parse("2023-08-10 10:45:00")
            },
            new User
            {
                FirstName = "Trịnh",
                LastName = "Đặng",
                FullName = "Trịnh Đặng",
                Nickname = "dangtrinh_",
                Avatar = "https://example.com/avatar20.jpg",
                Bio = "Chào các bạn! Hãy cùng tôi chia sẻ những khoảnh khắc tuyệt vời!",
                Tick = true,
                FollowingsCount = 400,
                FollowersCount = 9500,
                LikesCount = 30000,
                CreatedAt = DateTime.Parse("2023-03-18 19:10:20"),
                UpdatedAt = DateTime.Parse("2023-03-18 19:15:00")
            },
            new User
            {
                FirstName = "Nguyễn",
                LastName = "Bảo Linh",
                FullName = "Nguyễn Bảo Linh",
                Nickname = "baolinh_nguyen",
                Avatar = "https://example.com/avatar21.jpg",
                Bio = "Lên TikTok mỗi ngày cùng mình nha! 😘",
                Tick = false,
                FollowingsCount = 500,
                FollowersCount = 8500,
                LikesCount = 18000,
                CreatedAt = DateTime.Parse("2023-04-15 16:45:00"),
                UpdatedAt = DateTime.Parse("2023-04-15 16:50:20")
            },
            new User
            {
                FirstName = "Phạm",
                LastName = "Thanh Tuyền",
                FullName = "Phạm Thanh Tuyền",
                Nickname = "thanhtuyen_pham",
                Avatar = "https://example.com/avatar22.jpg",
                Bio = "Tôi chỉ muốn chia sẻ những niềm vui đến với mọi người! 🎈",
                Tick = true,
                FollowingsCount = 1200,
                FollowersCount = 16000,
                LikesCount = 85000,
                CreatedAt = DateTime.Parse("2023-05-22 13:00:00"),
                UpdatedAt = DateTime.Parse("2023-05-22 13:05:00")
            },
            new User
            {
                FirstName = "Bùi",
                LastName = "Vân Anh",
                FullName = "Bùi Vân Anh",
                Nickname = "vananh_bui",
                Avatar = "https://example.com/avatar23.jpg",
                Bio = "Mỗi ngày đều là một cơ hội mới để phát triển bản thân 💪",
                Tick = true,
                FollowingsCount = 1000,
                FollowersCount = 22000,
                LikesCount = 95000,
                CreatedAt = DateTime.Parse("2023-02-11 08:25:30"),
                UpdatedAt = DateTime.Parse("2023-02-11 08:30:00")
            },
            new User
            {
                FirstName = "Nguyễn",
                LastName = "Vũ Mạnh",
                FullName = "Nguyễn Vũ Mạnh",
                Nickname = "vumanh_nguyen",
                Avatar = "https://example.com/avatar24.jpg",
                Bio = "Hãy sống hết mình và làm điều bạn yêu thích! ❤️",
                Tick = true,
                FollowingsCount = 300,
                FollowersCount = 5000,
                LikesCount = 15000,
                CreatedAt = DateTime.Parse("2023-06-05 14:10:10"),
                UpdatedAt = DateTime.Parse("2023-06-05 14:15:30")
            },
            new User
            {
                FirstName = "Trần",
                LastName = "Minh Vũ",
                FullName = "Trần Minh Vũ",
                Nickname = "minhvu_tran",
                Avatar = "https://example.com/avatar25.jpg",
                Bio = "Cùng nhau trải nghiệm những điều tuyệt vời qua video 🎬",
                Tick = true,
                FollowingsCount = 950,
                FollowersCount = 13000,
                LikesCount = 50000,
                CreatedAt = DateTime.Parse("2022-12-01 11:40:00"),
                UpdatedAt = DateTime.Parse("2022-12-01 11:45:20")
            },
            new User
            {
                FirstName = "Lý",
                LastName = "Minh Tuấn",
                FullName = "Lý Minh Tuấn",
                Nickname = "minhtuan_ly",
                Avatar = "https://example.com/avatar26.jpg",
                Bio = "Chia sẻ những khoảnh khắc đời thường và các mẹo hay 🌟",
                Tick = false,
                FollowingsCount = 800,
                FollowersCount = 9500,
                LikesCount = 43000,
                CreatedAt = DateTime.Parse("2023-07-20 16:00:00"),
                UpdatedAt = DateTime.Parse("2023-07-20 16:05:30")
            },
            new User
            {
                FirstName = "Dương",
                LastName = "Thị Thu",
                FullName = "Dương Thị Thu",
                Nickname = "thithu_duong",
                Avatar = "https://example.com/avatar27.jpg",
                Bio = "Chào các bạn, mình là Thu và đây là hành trình TikTok của tôi 📸",
                Tick = true,
                FollowingsCount = 350,
                FollowersCount = 5000,
                LikesCount = 22000,
                CreatedAt = DateTime.Parse("2023-08-07 10:30:00"),
                UpdatedAt = DateTime.Parse("2023-08-07 10:35:40")
            },
            new User
            {
                FirstName = "Hoàng",
                LastName = "Linh Chi",
                FullName = "Hoàng Linh Chi",
                Nickname = "linhchi_hoang",
                Avatar = "https://example.com/avatar28.jpg",
                Bio = "Mọi thứ sẽ trở nên tuyệt vời nếu bạn có niềm đam mê 🔥",
                Tick = true,
                FollowingsCount = 1200,
                FollowersCount = 20000,
                LikesCount = 80000,
                CreatedAt = DateTime.Parse("2023-01-13 08:10:00"),
                UpdatedAt = DateTime.Parse("2023-01-13 08:15:30")
            }

                            // ... Thêm dữ liệu người dùng khác
            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }
    }
}
