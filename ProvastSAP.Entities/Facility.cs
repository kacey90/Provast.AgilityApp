using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Entities
{
    public class Facility : IEntityBase<Guid>
    {
        #region Properties
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Status { get; set; }
        public string UserSign { get; set; }
        public Guid Id { get; set; }
        public Guid FlatTypeId { get; set; }
        
        public Guid FloorId { get; set; }
        
        public Guid SiteId { get; set; }
        public bool IsStandardFlat { get; set; }
        public decimal Size { get; set; }
        #endregion

        #region Navigation Properties
        public FlatType FlatType { get; set; }
        public Floor Floor { get; set; }
        public Site Site { get; set; }

        #endregion
    }

    public class FacilityLog : IEntityBase<Guid>, ILogEntityBase<Guid>
    {
        #region Properties
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Status { get; set; }
        public string UserSign { get; set; }
        public Guid Id { get; set; }
        public Guid FlatTypeId { get; set; }

        public Guid FloorId { get; set; }

        public Guid SiteId { get; set; }
        public bool IsStandardFlat { get; set; }
        public decimal Size { get; set; }
        public int LogInstance { get; set; }

        #endregion
    }
}
