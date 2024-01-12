namespace Lesson8.Helpers
{
    public class UploadFileHelper
    {
        public async static Task<string> UploadFile(IFormFile file)
        {
            var fs = new FileStream(@$"wwwroot/{Guid.NewGuid()}{Path.GetExtension(file.FileName)}", FileMode.Create);
            await file.CopyToAsync(fs);

            return fs.Name;
        }
    }
}
