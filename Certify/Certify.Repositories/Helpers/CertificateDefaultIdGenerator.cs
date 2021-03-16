using Certify.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Repositories.Helpers
{
    public static class CertificateDefaultIdGenerator
    {
        public static string Generate(Course course, int numb)
        {
            var builder = new StringBuilder();
            builder.AppendFormat($"{course.EndDate.ToString("ddMMyyyy")}");
            builder.AppendFormat($"{course.CertificatesCount.ToString("000")}");
            builder.AppendFormat($"{(++numb).ToString("00000")}");
            return builder.ToString();
        }
    }
}
