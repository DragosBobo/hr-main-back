using HrAppDataAcces.Entities.Revisal_entities.Enums;
using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Employees
{
    public class ContractDto
    {
        public string NumarContract { get; set; }
        public DateTime DataInceputContract { get; set; }
        public DateTime? DataSfarsitContract { get; set; }
        public int Salariu { get; set; }
        public TipContract TipContract { get; set; }
        public TipDurata TipDurata { get; set; }
        public TipNorma TipNorma { get; set; }
        public ContractStareDto? StareCurenta { get; set; }
        public CorDto Cor { get; set; }
        public ContractEntity ToModel()
        {
            return new ContractEntity()
            {
                NumarContract = NumarContract,
                DataInceputContract = DataInceputContract,
                DataSfarsitContract = DataSfarsitContract,
                Salariu = Salariu,
                TipContract = TipContract,
                TipDurata = TipDurata,
                TipNorma = TipNorma,
                StareCurenta = StareCurenta.ToModel(),
                Cor = Cor.ToModel(),
                Id = Guid.NewGuid(),
            };
        }
        
    }
}
