using HrAppDataAcces.DTOs.Firm;
using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Employees
{
    public class SalariatDto
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Cnp { get; set; }
        public string Adresa { get; set; }
        public NationalitateDto Nationalitate { get; set; }
        public List<ContractDto> Contracte { get; set; }
        public LocalitateDto Localitate { get; set; }
        public DetaliiSalariatStrainDto DetaliiSalariatStrain { get; set; }
    }
}
