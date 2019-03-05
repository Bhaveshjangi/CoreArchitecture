using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoService _IdemoService;
        public DemoController(IDemoService IdemoService)
        {
            _IdemoService = IdemoService;
        }

        public IActionResult GetData()
        {
            try
            {
                return Ok(_IdemoService.GetData());

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}