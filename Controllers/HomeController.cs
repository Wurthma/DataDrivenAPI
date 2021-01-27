using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataDrivenAPI.Data;
using DataDrivenAPI.Models;

namespace DataDrivenAPI.Controllers
{
    [Route("v1")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<dynamic>> Get([FromServices] DataContext context)
        {
            var employee = new User { Username = "robin", Password = "robin", Role = "employee" };
            var manager = new User { Username = "batman", Password = "batman", Role = "manager" };
            var category = new Category { Title = "Informática" };
            var product = new Product { Category = category, Title = "Mouse", Price = 299, Description = "Mouse Gamer" };
            context.Users.Add(employee);
            context.Users.Add(manager);
            context.Categories.Add(category);
            context.Products.Add(product);
            await context.SaveChangesAsync();

            return Ok(new
            {
                message = "Dados configurados"
            });
        }
    }
}