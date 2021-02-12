using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Constants
{
    public static class Messages
    {
        public static string CarNameAndPriceInvalid = "Araç Modeli en az iki karakter ve Kiralama Ücreti sıfır liradan yüksek olmalıdır.";
        public static string Updated = "Güncellendi.";
        public static string Added = "Eklendi.";
        public static string Deleted = "Silindi.";
        public static string Listed = "Listelendi.";
        public static string MaintenanceTime = "Site bakımdadır.";
        internal static string CarNotRented="Araç kiralanamadı.";
        internal static string CarRented="Araç kiralandı.";
    }
}
