using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {//kullanıcının  göreceği mesajların hepsi artık buradan yazılır

        //car
        public static string CarAdded = "ürün eklendi";
        public static string CarNameInvalid = "ürün simi geçersiz";
        public static string MaintananceTime="Sistem bakımda";
        public static string CarsListed="Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";

        //brand
        public static string BrandNameInvalid = "Marka ikiden fazla harf içermelidir";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string MaintenanceTime;

        //color
        public static string ColorNameInvalid = "Renk ismi en az 2 harf içermelidir";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk Güncellendi";

        //Rental
        public static string AddRentalMessage = "Araç kiralama işlemi başarıyla eklendi.";
        public static string DeleteRentalMessage = "Araç kiralama işlemi başarıyla silindi.";
        public static string EditRentalMessage = "Araç kiralama işlemi başarıyla güncellendi.";
        public static string GetSuccessRentalMessage = "Araç kiralama işlemi bilgisi / bilgileri getirildi.";
        public static string GetErrorRentalMessage = "Araç kiralama işlemi bilgisi / bilgileri getirilemedi.";
        public static string CarAvaible = "Araç kiralanmaya uygundur.";
        public static string CarNotAvaible = "Araç kiralanmaya uygun değildir.";

        //User
        public static string AddUserMessage = "Üye başarıyla eklendi.";
        public static string DeleteUserMessage = "Üye başarıyla silindi.";
        public static string EditUserMessage = "Üye başarıyla güncellendi.";
        public static string GetSuccessUserMessage = "Üye bilgisi / bilgileri getirildi.";
        public static string GetErrorUserMessage = "Üye bilgisi / bilgileri getirilemedi.";

        //Customer
        public static string AddCustomerMessage = "Müşteri başarıyla eklendi.";
        public static string DeleteCustomerMessage = "Müşteri başarıyla silindi.";
        public static string EditCustomerMessage = "Müşteri başarıyla güncellendi.";
        public static string GetSuccessCustomerMessage = "Müşteri bilgisi / bilgileri getirildi.";
        public static string GetErrorCustomerMessage = "Müşteri bilgisi / bilgileri getirilemedi.";
        public static string ImageAdded = "resim eklendi";
        public static string OutOfImageLimit = "Resim limitine erişildi!";
        public static string AuthorizationDenied="";
        public static string AccessTokenCreated="";
        public static string UserAlreadyExists="Kullanıcı zaten var";
        public static string SuccessfulLogin="Başarıya giriş yapıldı";
        public static string UserNotFound="KUllanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string UserRegistered="kullanıcı kayıt edildi";
        public static string UserDeleted="Kullanıcı silindi";
        public static string UsersListed="Kullanıcılar listelendi";
        public static string UserUpdated="Kullanıcı güncellendi";
        public static string UserAdded="Kullanıcı eklendi";
    }
}
