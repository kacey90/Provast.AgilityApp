using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProvastSAP.WebAPI.BaseControllers;
using ProvastSAP.Services.Services;
using ProvastSAP.WebAPI.ViewModels;
using AutoMapper;
using ProvastSAP.Entities;

namespace ProvastSAP.WebAPI.Controllers
{
    public class FacilityController : BaseController
    {
        private readonly FacilityService _facilityService;

        public FacilityController(FacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        [HttpPost]
        [Route("Add")]
        public JsonResult Add([FromBody] FacilityVM model)
        {
            var facility = Mapper.Map<Facility>(model);
            _facilityService.Add(facility);
            _facilityService.SaveChanges();
            return Json(_facilityService.Get(facility.Id));
        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update([FromBody]FacilityVM model)
        {
            var facility = Mapper.Map<Facility>(model);
            _facilityService.Update(facility);
            _facilityService.SaveChanges();
            return Json(_facilityService.Get(facility.Id));
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
            return Json(_facilityService.GetAll());
        }


        [HttpGet]
        [Route("GetById")]
        public JsonResult Get(string id)
        {
            return Json(_facilityService.Get(ConvertToGuid(id)));
        }
    }
}
