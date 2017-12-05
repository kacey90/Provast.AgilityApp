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
    public class SiteController : BaseController
    {
        private readonly SiteService _siteService;

        public SiteController(SiteService siteService)
        {
            _siteService = siteService;
        }

        [HttpPost]
        [Route("Add")]
        public JsonResult Add([FromBody] SiteVM model)
        {
            var site = Mapper.Map<Site>(model);
            _siteService.Add(site);
            _siteService.SaveChanges();
            return Json(_siteService.Get(site.Id));
        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update([FromBody]SiteTypeVM model)
        {
            var site = Mapper.Map<Site>(model);
            _siteService.Update(site);
            _siteService.SaveChanges();
            return Json(_siteService.Get(site.Id));
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
            return Json(_siteService.GetAll());
        }


        [HttpGet]
        [Route("GetById")]
        public JsonResult Get(string id)
        {
            return Json(_siteService.Get(ConvertToGuid(id)));
        }
    }
}
