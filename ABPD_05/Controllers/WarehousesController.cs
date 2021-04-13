using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABPD_05.Controllers
{
    [Route("api/warehouses")]
    [ApiController]
    public class WarehousesController : ControllerBase
    {

        private readonly IDBService _service;

        public WarehousesController(IDBService dBService)
        {
            _service = dBService;
        }

        [HttpGet]
        public IActionResult GetAllOWarehouses()
        {
            return Ok(_service.getAllWarehouses());
        }
        [HttpPost]
        public IActionResult AddOrder(OrderRequest request)
        {
            try
            {
                int response = _service.AddProducts(request);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
