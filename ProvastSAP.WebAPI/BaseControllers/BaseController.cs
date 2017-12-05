using Microsoft.AspNetCore.Mvc;
using OryxDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvastSAP.WebAPI.BaseControllers
{
    [Route("api/[controller]")]
    public abstract class BaseController : Controller
    {
        protected readonly IUnitOfWork _unitOfWork;
        //protected IRepository<Error, int > _errorsRepository;

        public BaseController()
        {


        }

        [HttpGet]
        public abstract JsonResult Get();




        // GET api/values/5
        // [HttpGet("{id}")]
        // public abstract JsonResult Get(Tld id);


        public Guid ConvertToGuid(string id)
        {

            Guid NewId;
            NewId = (string.IsNullOrEmpty(id)) ? Guid.NewGuid() : Guid.Parse(id);
            return NewId;
        }

        public string getToken()
        {
            string token = "";
            foreach (var item in Request.Headers)
            {
                if (item.Key == "Authorization")
                {
                    token = item.Value.ToString().Replace("Bearer ", "");
                }
            }
            return token;
        }
    }
}
