using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using ReCapProject.Core.Utilities.Results;

namespace ReCapProject.Core.Utilities.FileHelper
{
    public class FileHelper
    {
        //public static string Add(IFormFile file)
        //{
        //    string extension = Path.GetExtension(file.FileName).ToUpper();
        //    string newGUID = CreateGuid() + extension;
        //    var directory = Directory.GetCurrentDirectory() + "\\wwwroot";
        //    var path = directory + @"\Images";
        //    if (!Directory.Exists(path))
        //    {
        //        Directory.CreateDirectory(path);
        //    }
        //    string imagePath;
        //    using (FileStream fileStream = File.Create(path + "\\" + newGUID))
        //    {
        //        file.CopyToAsync(fileStream);
        //        imagePath = path + "\\" + newGUID;
        //        fileStream.Flush();
        //    }
        //    return imagePath.Replace("\\", "/");
        //}

        //public static void Update(IFormFile file, string oldPath)
        //{
        //    string extension = Path.GetExtension(file.FileName).ToUpper();
        //    using (FileStream fileStream = File.Open(oldPath.Replace("/", "\\"), FileMode.Open))
        //    {
        //        file.CopyToAsync(fileStream);
        //        fileStream.Flush();
        //    }
        //}

        //public static void Delete(string imagePath)
        //{
        //    if (File.Exists(imagePath.Replace("/", "\\")) && Path.GetFileName(imagePath) != "default.png")
        //    {
        //        File.Delete(imagePath.Replace("/", "\\"));
        //    }
        //}

        //public static string CreateGuid()
        //{
        //    return Guid.NewGuid().ToString("N") + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Year;
        //}

        static string directory = Directory.GetCurrentDirectory() + @"\wwwroot\";
        static string path = @"Images\";
        public static string Add(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName).ToUpper();
            string newFileName = Guid.NewGuid().ToString("N") + extension;
            if (!Directory.Exists(directory + path))
            {
                Directory.CreateDirectory(directory + path);
            }
            using (FileStream fileStream = File.Create(directory + path + newFileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return (path + newFileName).Replace("\\", "/");
        }

        public static string Update(IFormFile file, string oldImagePath)
        {
            Delete(oldImagePath);
            return Add(file);
        }

        public static void Delete(string imagePath)
        {
            if (File.Exists(directory + imagePath.Replace("/", "\\"))
                && Path.GetFileName(imagePath) != "default.png")
            {
                File.Delete(directory + imagePath.Replace("/", "\\"));
            }
        }
    }

}
