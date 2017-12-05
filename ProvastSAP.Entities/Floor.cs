using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Entities
{
    public class Floor : IEntityBase<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Status { get; set; }
        public string UserSign { get; set; }
    }

    public class FloorLog : IEntityBase<Guid>, ILogEntityBase<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Status { get; set; }
        public string UserSign { get; set; }
        public int LogInstance { get; set; }
    }
}
