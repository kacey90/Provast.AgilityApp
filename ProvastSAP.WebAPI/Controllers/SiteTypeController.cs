using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProvastSAP.Entities;
using ProvastSAP.Services.Services;
using ProvastSAP.WebAPI.BaseControllers;
using ProvastSAP.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvastSAP.WebAPI.Controllers
{
    public class SiteTypeController : BaseController
    {
        private readonly SiteTypeService _siteTypeService;

        public SiteTypeController(SiteTypeService siteTypeService)
        {
            _siteTypeService = siteTypeService;
        }

        [HttpPost]
        [Route("Add")]
        public JsonResult Add([FromBody] SiteTypeVM model)
        {
            var siteType = Mapper.Map<SiteType>(model);
            _siteTypeService.Add(siteType);
            _siteTypeService.SaveChanges();
            return Json(_siteTypeService.Get(siteType.Id));
        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update([FromBody]SiteTypeVM model)
        {
            var siteType = Mapper.Map<SiteType>(model);
            _siteTypeService.Update(siteType);
            _siteTypeService.SaveChanges();
            return Json(_siteTypeService.Get(siteType.Id));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        public override JsonResult Get()
        {
            return Json(_siteTypeService.GetAll());
        }


        [HttpGet]
        [Route("GetById")]
        public JsonResult Get(string id)
        {
            return Json(_siteTypeService.Get(ConvertToGuid(id)));
        }
    }
}
