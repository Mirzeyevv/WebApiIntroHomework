using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webIntroHW.Entities;
using webIntroHW.Services;

namespace webIntroHW.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{
    private readonly ICategoryService _categoryService = categoryService;

    [HttpPost]
    public IActionResult AddCategory(Category category)
    {
        var newCategory = _categoryService.Add(category);
        return Ok(newCategory);
    }

    [HttpGet]

    public IActionResult GetAllCategories()
    {
        var categoryList = _categoryService.GetAll();
        return Ok(categoryList);
    }

    [HttpGet("id")]
    public IActionResult GetById([FromQuery] int id)
    {
        var category = _categoryService.GetById(id);
        return Ok(category);
    }

    [HttpDelete("id")]

    public IActionResult DeleteById(int id) {

        var isDeleted =_categoryService.Delete(id);
        return Ok(isDeleted);    
        
    }


    
}
