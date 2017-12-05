using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ProvastSAPContext Init();
    }
}
