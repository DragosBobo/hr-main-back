using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Firm
{
    public class FirmDto
    {
        public string Adresa { get; set; }
        public List<AngajatorAuditEntity> AuditEntries { get; set; }
        public ContactEntity Contact { get; set; }
        public DetaliiAngajatorEntity Detalii { get; set; }
        public LocalitateEntity Localitate { get; set; }
    }
}
