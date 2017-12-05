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
    public class FloorController : BaseController
    {
        private readonly FloorService _floorService;

        public FloorController(FloorService floorService)
        {
            _floorService = floorService;
        }

        [HttpPost]
        [Route("Add")]
        public JsonResult Add([FromBody] FloorVM model)
        {
            var floor = Mapper.Map<Floor>(model);
            _floorService.Add(floor);
            _floorService.SaveChanges();
            return Json(_floorService.Get(floor.Id));
        }

        [HttpPost]
        [Route("Update")]
        public JsonResult Update([FromBody]FloorVM model)
        {
            var floor = Mapper.Map<Floor>(model);
            _floorService.Update(floor);
            _floorService.SaveChanges();
            return Json(_floorService.Get(floor.Id));
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
            return Json(_floorService.GetAll());
        }


        [HttpGet]
        [Route("GetById")]
        public JsonResult Get(string id)
        {
            return Json(_floorService.Get(ConvertToGuid(id)));
        }
    }
}
