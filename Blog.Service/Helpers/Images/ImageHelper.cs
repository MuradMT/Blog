using Blog.Entity.Dtos.Images;
using Blog.Entity.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Blog.Service.Helpers.Images;

public class ImageHelper(IWebHostEnvironment env) : IImageHelper
{
    private readonly string wwwroot = env.WebRootPath;
    private const string imagesFolder = "images";
    private const string articleImagesFolder = "article-images";
    private const string userImagesFolder = "user-images";

    private string ReplaceInvalidChars(string fileName)
    {
        return fileName.Replace("İ", "I")
             .Replace("ı", "i")
             .Replace("Ğ", "G")
             .Replace("ğ", "g")
             .Replace("Ü", "U")
             .Replace("ü", "u")
             .Replace("ş", "s")
             .Replace("Ş", "S")
             .Replace("Ö", "O")
             .Replace("ö", "o")
             .Replace("Ç", "C")
             .Replace("ç", "c")
             .Replace("é", "")
             .Replace("!", "")
             .Replace("'", "")
             .Replace("^", "")
             .Replace("+", "")
             .Replace("%", "")
             .Replace("/", "")
             .Replace("(", "")
             .Replace(")", "")
             .Replace("=", "")
             .Replace("?", "")
             .Replace("_", "")
             .Replace("*", "")
             .Replace("æ", "")
             .Replace("ß", "")
             .Replace("@", "")
             .Replace("€", "")
             .Replace("<", "")
             .Replace(">", "")
             .Replace("#", "")
             .Replace("$", "")
             .Replace("½", "")
             .Replace("{", "")
             .Replace("[", "")
             .Replace("]", "")
             .Replace("}", "")
             .Replace(@"\", "")
             .Replace("|", "")
             .Replace("~", "")
             .Replace("¨", "")
             .Replace(",", "")
             .Replace(";", "")
             .Replace("`", "")
             .Replace(".", "")
             .Replace(":", "")
             .Replace(" ", "");
    }

    public void Delete(string imageName)
    {
        var fileToDelete = $"{wwwroot}/{imagesFolder}/{imageName}";
        if(File.Exists(imageName)) File.Delete(fileToDelete);
    }

    public async Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imageType, string folderName = null)
    {
        //Step 1 - detects folder name (user or article) , creates path
        folderName ??= imageType == ImageType.User ? userImagesFolder : articleImagesFolder;
        var path = $"{wwwroot}/{imagesFolder}/{folderName}";

        //step 2 - checks if path exists,if not ,then creates new path
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        //Step 3 - seperates image file name and extension
        string oldFileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
        string fileExtension = Path.GetExtension(imageFile.FileName);

        //Step 4 - creates a new file name with our input name
        name = ReplaceInvalidChars(name);
        var dateTime = DateTime.Now;
        var newFileName = $"{name}_{dateTime.Millisecond}.{fileExtension}";

        //Step 5 - Combines new file name with folder path
        var filePath = Path.Combine(path,newFileName);

        //Step 6 - Creates stream in order to create file in this specific folder
        await using var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
        await imageFile.CopyToAsync(stream);
        await stream.FlushAsync();

        //Step 7 - Create success message
        var message = imageType == ImageType.User ? $"User picture with {newFileName} name succesfully created!"
            : $"Article picture with {newFileName} name succesfully created!";
        //Step 8 - Return Image uploaded dto
        return new ImageUploadedDto()
        {
            FullName = $"{folderName}/{newFileName}"
        };
    }
}
