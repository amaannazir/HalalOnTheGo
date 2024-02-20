using HalalOnTheGo.Server.Services.CategoryService;
using HalalOnTheGo.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HalalOnTheGo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
         public async Task <ActionResult<List<Category>>> GetCategories()
        {
            //Return Status code 200 "OK" to server
            return Ok(await _categoryService.GetCategories());


        }
    }
}
