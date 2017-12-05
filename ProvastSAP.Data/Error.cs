using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProvastSAP.Data
{
    public class Error : IEntityBase<int>
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string UserSign { get; set; }
        [MaxLength(1)]
        public string Status { get; set; }
    }
}
