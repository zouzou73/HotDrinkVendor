using HotDrinkVendor.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDrinkVendor.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DrinkFactoryController : ControllerBase
    {
        private readonly ILogger<DrinkFactoryController> _logger;
        public DrinkFactoryController(ILogger<DrinkFactoryController> logger)
        {
            _logger = logger;

        }


        [HttpGet]
        public double Get(string drinks)
        {
            return Factory.drinkFactory(drinks);
        }
    }
}