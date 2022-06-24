using System;
using APIInteractiveLab1.Models;
using Microsoft.AspNetCore.Mvc;
namespace APIInteractiveLab1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase

    {
        public string? Name { get; private set; }
        public int Id { get; private set; }

        [HttpGet("{name}")]
        public Coffee Get(string? name) => new Coffee(Id = (name != null ? 7 : -1), Name = name ?? "latte");
       
        [HttpGet("lover")]
        public string GetCoffeeLover()
        {
            return "I like coffee!";
        }
    }
}

