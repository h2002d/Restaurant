using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Helpers
{
    public class SliderImageHelper
    {
        private IHostingEnvironment _hostingEnvironment;
        public SliderImageHelper()
        {

        }
        public SliderImageHelper(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public string SaveSliderImageToPath(IFormFile file)
        {
            if (file == null)
                return null;
            string shortLocation = $"\\images\\sliders\\";
            string uploads = Path.Combine(_hostingEnvironment.WebRootPath + shortLocation);
            if (!Directory.Exists(uploads))
            {
                DirectoryInfo di = Directory.CreateDirectory(uploads);
            }

            if (file.Length > 0)
            {
                //item.CopyTo(fileStream);
                var timeSpan = DateTime.Now.ToString("yyyyMMddHHmmssffff");
                var filePath = Path.Combine(uploads, file.FileName + timeSpan);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                return $"/images/sliders/{file.FileName + timeSpan}";
            }
            return null;
        }
    }
}
