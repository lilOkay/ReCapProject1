using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {//kullanıcının  göreceği mesajların hepsi artık buradan yazılır
        public static string CarAdded = "ürün eklendi";
        public static string CarNameInvalid = "ürün simi geçersiz";
        public static string MaintananceTime="Sistem bakımda";
        public static string CarsListed="Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string BrandNameInvalid = "Marka ikiden fazla harf içermelidir";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string MaintenanceTime;
        public static string ColorNameInvalid = "Renk ismi en az 2 harf içermelidir";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk Güncellendi";
    }
}
