using HrAppDataAcces.Entities.Revisal_entities.Enums;
using System;
using System.Collections.Generic;

namespace HrAppDataAcces.Entities.Revisal_entities
{public class ContractEntity : AuditableEntity
    {
        public string NumarContract { get; set; }
        public DateTime DataInceputContract { get; set; }
        public DateTime? DataSfarsitContract { get; set; }
        public int Salariu { get; set; }
        public TipContract TipContract { get; set; }
        public TipDurata TipDurata { get; set; }
        public TipNorma TipNorma { get; set; }
        public ContractStareEntity StareCurenta { get; set; }
        public CorEntity Cor { get; set; }
    }
}
