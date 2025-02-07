using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Data;

namespace RealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApiDbContext _dbContext;
        public CategoriesController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        [HttpGet]
        [Authorize] 
        public IActionResult Get()
        {
            return Ok(_dbContext.Categories);
        }
    }
}
