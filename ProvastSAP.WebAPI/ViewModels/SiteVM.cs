using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvastSAP.WebAPI.ViewModels
{
    public class SiteVM : BaseViewModel
    {
        public string Name { get; set; }
        public Guid SiteTypeId { get; set; }
        public bool HasCommonArea { get; set; }
    }
}
