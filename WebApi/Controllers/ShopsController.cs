using Lightpoint.Task.DAL.Entities;
using Lightpoint.Task.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ShopsController : ApiController
    {
        private IUnitOfWork unitOfWork;

        public ShopsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            //var shops = new List<Shop>() { new Shop() { Id = 1, Name = "test", Adress = "test adress", Mode = "test mode" } };
            var shops = unitOfWork.GetShopRepository().GetAll();
            var response = Request.CreateResponse(HttpStatusCode.OK, shops);
            return response;
        }
    }
}
