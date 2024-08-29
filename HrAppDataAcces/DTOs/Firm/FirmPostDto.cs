using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Firm
{
    public class FirmPostDto
    {
        public string Adresa { get; set; }
        public ContactDto Contact { get; set; }
        public DetaliiAngajatorDto Detalii { get; set; }
        public LocalitateDto Localitate { get; set; }
        public AngajatorEntity ToModel()
        {
            return new AngajatorEntity()
            {
                Adresa = Adresa,
                Contact = Contact.ToModel(),
                Detalii = Detalii.ToModel(),
                Localitate = Localitate.ToModel(),
                Id = Guid.NewGuid()
            };
        }
    }
}
