using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeather.Model
{
    public class Country
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Key { get; set; }
        public static List<Country> LoadData()
        {
            List<Country> listCountry = new List<Country>();
            listCountry.Add(new Country() { Id = 1, Name = "An Giang", Key = "An Giang" });
            listCountry.Add(new Country() { Id = 2, Name = "Bà Rịa - Vũng Tàu", Key = "vung tau" });
            listCountry.Add(new Country() { Id = 3, Name = "Bắc Kạn", Key = "bac kan" });
            listCountry.Add(new Country() { Id = 4, Name = "Bạc Liêu", Key = "Bạc Liêu" });
            listCountry.Add(new Country() { Id = 5, Name = "Bắc Ninh", Key = "bac ninh" });
            listCountry.Add(new Country() { Id = 6, Name = "Bắc Giang", Key = "bac giang" });
            listCountry.Add(new Country() { Id = 7, Name = "Bến Tre", Key = "ben tre" });
            listCountry.Add(new Country() { Id = 8, Name = "Bình Định", Key = "Bình Định" });
            listCountry.Add(new Country() { Id = 9, Name = "Bình Dương", Key = "Bình Dương" });
            listCountry.Add(new Country() { Id = 10, Name = "Bình Phước", Key = "Bình Phước" });
            listCountry.Add(new Country() { Id = 11, Name = "Bình Thuận", Key = "Bình Thuận" });
            listCountry.Add(new Country() { Id = 12, Name = "Cà Mau", Key = "ca mau" });
            listCountry.Add(new Country() { Id = 13, Name = "Cao Bằng", Key = "cao bang" });
            listCountry.Add(new Country() { Id = 14, Name = "Đắk Lắk", Key = "Dak Lak" });
            listCountry.Add(new Country() { Id = 15, Name = "Đắk Nông", Key = "Đắk Nông" });
            listCountry.Add(new Country() { Id = 16, Name = "Điện Biên", Key = "Điện Biên" });
            listCountry.Add(new Country() { Id = 17, Name = "Đồng Nai", Key = "Dồng Nai" });
            listCountry.Add(new Country() { Id = 18, Name = "Đồng Tháp", Key = "Đồng Tháp" });
            listCountry.Add(new Country() { Id = 19, Name = "Gia Lai", Key = "Gia Lai" });
            listCountry.Add(new Country() { Id = 20, Name = "Hà Giang", Key = "ha giang" });
            listCountry.Add(new Country() { Id = 21, Name = " Hà Nam", Key = "Hà Nam" });
            listCountry.Add(new Country() { Id = 22, Name = "Hà Tĩnh", Key = "ha tinh" });
            listCountry.Add(new Country() { Id = 23, Name = "Hải Dương", Key = "hai duong" });
            listCountry.Add(new Country() { Id = 24, Name = "Hậu Giang", Key = "Hậu Giang" });
            listCountry.Add(new Country() { Id = 25, Name = "Hòa Bình", Key = "hoa binh" });
            listCountry.Add(new Country() { Id = 26, Name = "Bình Thuận", Key = "Bình Thuận" });
            listCountry.Add(new Country() { Id = 27, Name = "Hưng Yên", Key = "hung yen" });
            listCountry.Add(new Country() { Id = 28, Name = "Khánh Hòa", Key = "Khánh Hoà" });
            listCountry.Add(new Country() { Id = 29, Name = "Kon Tum", Key = "kon tum" });
            listCountry.Add(new Country() { Id = 30, Name = "Lai Châu", Key = "Lai Châu" });
            listCountry.Add(new Country() { Id = 31, Name = "Lâm Đồng", Key = "Lâm Đồng" });
            listCountry.Add(new Country() { Id = 32, Name = "Lạng Sơn", Key = "lang son" });
            listCountry.Add(new Country() { Id = 33, Name = "Lào Cai", Key = "lao cai" });
            listCountry.Add(new Country() { Id = 34, Name = "Long An", Key = "Long An" });
            listCountry.Add(new Country() { Id = 35, Name = "Nam Định", Key = "Nam Dinh" });
            listCountry.Add(new Country() { Id = 36, Name = "Nghệ An", Key = "Nghệ An" });
            listCountry.Add(new Country() { Id = 37, Name = "Ninh Thuận", Key = "Ninh Thuận" });
            listCountry.Add(new Country() { Id = 38, Name = "Phú Thọ", Key = "Phú Thọ" });
            listCountry.Add(new Country() { Id = 39, Name = "Quảng Bình", Key = "Quảng Bình" });
            listCountry.Add(new Country() { Id = 40, Name = "Quảng Nam", Key = "Quảng Nam" });
            listCountry.Add(new Country() { Id = 41, Name = "Quảng Ngãi", Key = "quang ngai" });
            listCountry.Add(new Country() { Id = 42, Name = "Quảng Ninh", Key = "tay ninh" });
            listCountry.Add(new Country() { Id = 43, Name = "Quảng Trị", Key = "Quảng Trị" });
            listCountry.Add(new Country() { Id = 44, Name = "Sóc Trăng", Key = "soc trang" });
            listCountry.Add(new Country() { Id = 45, Name = "Sơn La", Key = "son la" });
            listCountry.Add(new Country() { Id = 46, Name = "Tây Ninh", Key = "tay ninh" });
            listCountry.Add(new Country() { Id = 47, Name = "Ninh Bình", Key = "ninh binh" });
            listCountry.Add(new Country() { Id = 48, Name = "Thái Bình", Key = "thai binh" });
            listCountry.Add(new Country() { Id = 49, Name = "Thanh Hóa", Key = "thanh hoa" });
            listCountry.Add(new Country() { Id = 50, Name = "Thừa Thiên Huế", Key = "hue" });
            listCountry.Add(new Country() { Id = 51, Name = "Tiền Giang", Key = "tien giang" });
            listCountry.Add(new Country() { Id = 52, Name = "Trà Vinh", Key = "tra vinh" });
            listCountry.Add(new Country() { Id = 53, Name = "Tuyên Quang", Key = "tuyen quang" });
            listCountry.Add(new Country() { Id = 54, Name = "Vĩnh Long", Key = "vinh long" });
            listCountry.Add(new Country() { Id = 55, Name = "Vĩnh Phúc", Key = "Vĩnh Phúc" });
            listCountry.Add(new Country() { Id = 56, Name = "Yên Bái", Key = "yen bai" });
            listCountry.Add(new Country() { Id = 57, Name = "Phú Yên", Key = "Phú Yên" });
            listCountry.Add(new Country() { Id = 58, Name = "Cần Thơ", Key = "can tho" });
            listCountry.Add(new Country() { Id = 59, Name = "Đà Nẵng", Key = "da nang" });
            listCountry.Add(new Country() { Id = 60, Name = "Hải Phòng", Key = "haiphong" });
            listCountry.Add(new Country() { Id = 61, Name = "Hà Nội", Key = "hanoi" });
            listCountry.Add(new Country() { Id = 62, Name = "Hồ Chí Minh", Key = "ho chi minh" });
            return listCountry;
        }
    }
}
