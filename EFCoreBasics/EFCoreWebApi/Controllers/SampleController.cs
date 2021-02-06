using System;
using System.Threading.Tasks;
using EFCoreWebApi.EF;
using EFCoreWebApi.Initializers;
using Microsoft.AspNetCore.Mvc;
using static EFCoreWebApi.Constants.Constants;

namespace EFCoreWebApi.Controllers {

    [ApiController]
    [Route(BASE_PATH)]
    public class SampleController : Controller {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly IDataInitializer _dataInitializer;
        private readonly ApplicationDbContext _applicationDbContext;

        /*------------------------ METHODS REGION ------------------------*/
        public SampleController(IDataInitializer dataInitializer,
                                ApplicationDbContext applicationDbContext) {
            _dataInitializer = dataInitializer;
            _applicationDbContext = applicationDbContext;
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
