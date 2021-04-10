using System.Runtime.Serialization;
using ReCapProject.Core.Entities.Concrete;

namespace ReCapProject.Business.Constants
{
    public static class Messages
    {
        public static string CarNameAndPriceInvalid = "Araç Modeli en az iki karakter ve Kiralama Ücreti sıfır liradan yüksek olmalıdır.";
        public static string Updated = "Güncellendi.";
        public static string Added = "Eklendi.";
        public static string Deleted = "Silindi.";
        public static string Listed = "Listelendi.";
        public static string Successful ="Başarılı";  
        public static string MaintenanceTime = "Site bakımdadır.";
        public static string CarNotRented = "Araç kiralanamadı.";
        public static string CarRented = "Araç kiralandı.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün bulunmaktadır.";
        public static string ImageLimit = "Fotoğraf limiti aşıldı.";
        public static string ImageLimitExpiredForCar = "Bir arabaya maximum 5 fotoğraf eklenebilir";
        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };
        public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar" + string.Join(",", ValidImageFileTypes);
        public static string CarImageMustBeExists = "Böyle bi resim bulunamadı";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
