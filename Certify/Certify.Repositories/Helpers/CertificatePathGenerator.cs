using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Repositories.Helpers
{
    public class CertificatePathGenerator
    {
        public static string ServerLocalPath(string certificateId, IWebHostEnvironment webHostEnvironment)
        {
            var webRootPath = webHostEnvironment.WebRootPath;
            return Path.Combine(webRootPath, string.Format("certificates\\{0}")); ;
        }
    }
}
