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
    public class FlatTypeController : BaseController
    {
        private readonly FlatTypeService _flatTypeService;

        public FlatTypeController(FlatTypeService flatTypeService)
        {
            _flatTypeService = flatTypeService;
        }

        [HttpPost]
        [Route("Add")]
        public JsonResult Add([FromBody] FlatTypeVM model)
        {
            var flatType = Mapper.Map<FlatType>(model);
            _flatTypeService.Add(flatType);
            _flatTypeService.SaveChanges();
            return Json(_flatTypeService.Get(flatType.Id));
        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update([FromBody]FlatTypeVM model)
        {
            var flatType = Mapper.Map<FlatType>(model);
            _flatTypeService.Update(flatType);
            _flatTypeService.SaveChanges();
            return Json(_flatTypeService.Get(flatType.Id));
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
            return Json(_flatTypeService.GetAll());
        }


        [HttpGet]
        [Route("GetById")]
        public JsonResult Get(string id)
        {
            return Json(_flatTypeService.Get(ConvertToGuid(id)));
        }
    }
}
