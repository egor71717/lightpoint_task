using Lightpoint.Task.DAL.Interface;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private IUnitOfWork unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public HttpResponseMessage Get(Int32 shopId)
        {
            var products = unitOfWork.GetProductRepository().GetAll().Where(prod => { return prod.ShopId == shopId; });
            var response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            //var shops = new List<Shop>() { new Shop() { Id = 1, Name = "test", Adress = "test adress", Mode = "test mode" } };
            var products = unitOfWork.GetProductRepository().GetAll();
            var response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }

    }
}
