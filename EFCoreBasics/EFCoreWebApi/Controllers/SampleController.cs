using System;
using System.Threading.Tasks;
using EFCoreWebApi.Initializers;
using Microsoft.AspNetCore.Mvc;
using static EFCoreWebApi.Constants.Constants;

namespace EFCoreWebApi.Controllers {

    [ApiController]
    [Route(BASE_PATH)]
    public class SampleController : Controller {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly IDataInitializer _dataInitializer;

        /*------------------------ METHODS REGION ------------------------*/
        public SampleController(IDataInitializer dataInitializer) {
            _dataInitializer = dataInitializer;
        }

        [HttpGet(PATH_SEED_DATA)]
        public async Task<IActionResult> SeedData() {
            try {
                await _dataInitializer.SeedDataAsync();
                return Ok();
            } catch (Exception) {
                return BadRequest();
            }
        }

    }

}
