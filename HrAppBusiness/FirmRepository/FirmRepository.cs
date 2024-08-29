using HrAppDataAcces;
using HrAppDataAcces.DTOs.Firm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppBusiness.FirmRepository
{
    public class FirmRepository : IFirmRepository
    {
        private readonly DataBaseContext _context;
        public FirmRepository(DataBaseContext context)
        {
            _context = context;      
        }
        public Task<FirmPostDto> CreateFirm(FirmPostDto firmPost)
        {
            var entity = firmPost.ToModel();
            _context.Firms.Add(entity); 
            _context.SaveChanges();
            return Task.FromResult(firmPost);
        }

        public Task<List<FirmDto>> GetFirms()
        {
            var firms = _context.Firms.Select(f => new FirmDto()
            {
                Adresa = f.Adresa,
                AuditEntries = f.AuditEntries,
                Contact = f.Contact,
                Detalii = f.Detalii,
                Localitate = f.Localitate,
            }).ToList();
            return Task.FromResult(firms);
        }
    }
}
