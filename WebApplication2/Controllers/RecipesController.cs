using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace WebApplication2.Controllers
{
    public class AddRecipeInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime dateCooked { get; set; }
        public string[] Ingredients { get; set; }   
    }
    public class RecipesController: Controller
    {
        public IActionResult Add(AddRecipeInputModel inputModel) 
        {
            return this.Json(inputModel);

        }

        public IActionResult Edit()
        {
            return this.View();
        }
    }

}
