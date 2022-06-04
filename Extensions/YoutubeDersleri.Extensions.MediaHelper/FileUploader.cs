namespace YoutubeDersleri.Extensions.MediaHelper
{
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.IO;
    using System.Linq;

    public class FileUploader
    {
        public bool UploadFileBase(IFormFile file, string source_path)
        {
            if (file == null || file.Length == 0)
                return false;

            var extension = Path.GetExtension(file.FileName).Trim('.').ToLower();
            if (!(new[] { "jpg", "png", "jpeg" }.Contains(extension)))
                return false;

            var local_image_dir = $"{source_path}";
            var local_image_path = $"{local_image_dir}/{file.FileName}";

            if (!Directory.Exists(Path.Combine(local_image_dir)))
                Directory.CreateDirectory(Path.Combine(local_image_dir));

            using (Stream fileStream = new FileStream(local_image_path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return true;
        }

        public bool UploadBase64(string base64, string source_path)
        {
            string[] base_split = base64.Split(',');
            var bytes = Convert.FromBase64String(base_split[1]);

            var extension_split = base_split[0].Split('/');
            var extension = extension_split[1].Split(';')[0]; //jpeg

            if (!(new[] { "jpg", "png", "jpeg" }.Contains(extension)))
                return false;

            var guid = Guid.NewGuid().ToString();

            var local_image_dir = $"{source_path}";
            var local_image_path = $"{local_image_dir}/{guid}.{extension}";

            if (!Directory.Exists(Path.Combine(local_image_dir)))
                Directory.CreateDirectory(Path.Combine(local_image_dir));

            using (var image_file = new FileStream(local_image_path, FileMode.Create))
            {
                image_file.Write(bytes, 0, bytes.Length);
                image_file.Flush();
            }

            return true;
        }

        public string UploadCdn(string source_path)
        {
            var config = new Account("dxi6uiicg", "513183697862813", "5-updEaMVTOM5pcq2q9VsqC4faQ");

            var test = new Cloudinary(config);
            test.Api.Secure = true;

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(source_path)
            };
            var uploadResult = test.Upload(uploadParams);

            return uploadResult.SecureUrl.ToString();
        }
    }
}