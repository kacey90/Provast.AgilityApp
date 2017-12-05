using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SecurityContext Init();
    }
}
