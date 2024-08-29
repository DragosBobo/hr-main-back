using HrAppDataAcces.Entities.Revisal_entities.Enums;
using System;
using System.Collections.Generic;

namespace HrAppDataAcces.Entities.Revisal_entities
{public class DetaliiSalariatStrainAuditEntity : AuditEntity
    {
        public DateTime? DataInceputAutorizatie { get; set; }
        public DateTime? DataSfarsitAutorizatie { get; set; }
        public TipAutorizatie TipAutorizatie { get; set; }
    }
}
