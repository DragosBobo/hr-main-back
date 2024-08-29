using System;
using System.Collections.Generic;

namespace HrAppDataAcces.Entities.Revisal_entities
{public class ContractStareSuspendareEntity : ContractStareEntity
    {
        public DateTime DataInceput { get; set; }
        public DateTime? DataIncetare { get; set; }
        public DateTime? DataSfarsit { get; set; }
        public string Explicatie { get; set; }
        public TemeiSuspendareEntity TemeiLegal { get; set; }
    }
}
