using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Entities
{
    public class Site : IEntityBase<Guid>
    {
        #region Properties
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SiteTypeId { get; set; }
        public bool HasCommonArea { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Status { get; set; }
        public string UserSign { get; set; }
        #endregion

        #region Naviation Properties
        public SiteType SiteType { get; set; }
        
        #endregion
    }

    public class SiteLog : IEntityBase<Guid>, ILogEntityBase<Guid>
    {
        #region Properties
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SiteTypeId { get; set; }
        public bool HasCommonArea { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Status { get; set; }
        public string UserSign { get; set; }
        public int LogInstance { get; set; }
        #endregion

        
    }
}
