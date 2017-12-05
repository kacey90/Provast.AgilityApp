using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvastSAP.WebAPI.ViewModels
{
    public class FacilityVM : BaseViewModel
    {
        public Guid FlatTypeId { get; set; }

        public Guid FloorId { get; set; }

        public Guid SiteId { get; set; }
        public bool IsStandardFlat { get; set; }
        public decimal Size { get; set; }
    }
}
