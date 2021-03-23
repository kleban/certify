using Certify.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Repositories
{
    public class CertificateRepository
    {
        private readonly CertifyDbContext _ctx;

        public CertificateRepository(CertifyDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task CreateAsync(Certificate certificate, int courseId)
        {
            certificate.Course = _ctx.Courses.First(x => x.Id == courseId);
            await _ctx.Certificates.AddAsync(certificate);
            await _ctx.SaveChangesAsync();
        }

        public async Task<Certificate> GetAsync(string id)
        {
            return _ctx.Certificates.First(x=> x.Id == id);
        }
    }
}
