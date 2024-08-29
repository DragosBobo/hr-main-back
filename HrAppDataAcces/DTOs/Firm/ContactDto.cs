using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Firm
{
    public class ContactDto
    {
        public string Email { get; set; }
        public string Fax { get; set; }
        public string ReprezentantLegal { get; set; }
        public string Telefon { get; set; }
        public ContactEntity ToModel()
        {
            return new ContactEntity
            {
                Email = Email,
                Fax = Fax,
                ReprezentantLegal = ReprezentantLegal,
                Telefon = Telefon,
                Id = Guid.NewGuid()
            };
        }
    }
}

