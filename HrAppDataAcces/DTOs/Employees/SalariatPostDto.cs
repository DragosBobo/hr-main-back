using HrAppDataAcces.DTOs.Firm;
using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Employees
{
    public class SalariatPostDto
    {
        public Guid FirmId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Cnp { get; set; }
        public string Adresa { get; set; }
        public NationalitateEntity Nationalitate { get; set; }
        public List<ContractDto> Contracte { get; set; }
        public LocalitateDto Localitate { get; set; }
        public DetaliiSalariatStrainDto DetaliiSalariatStrain { get; set; }
        public SalariatEntity ToModel()
        {
            return new SalariatEntity
            {
                FirmId = FirmId,
                Nume = Nume,
                Prenume = Prenume,
                Cnp = Cnp,
                Adresa = Adresa,
                Nationalitate = Nationalitate,
                Contracte = ToModelList(Contracte),
                Localitate = Localitate.ToModel(),
                DetaliiSalariatStrain = DetaliiSalariatStrain.ToModel(),
                Id = Guid.NewGuid(),
            };

        }
        private static List<ContractEntity> ToModelList(List<ContractDto> contract)
        {
            var result = new List<ContractEntity>();
            foreach (ContractDto contractDto in contract)
            {
                result.Add(contractDto.ToModel());
            }
            return result;
        }
    }
}
