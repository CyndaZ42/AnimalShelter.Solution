using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//namespace AnimalShelter.Controllers
//{
//  [ApiController]
//  [Route("[controller]")]
//  public class AnimalShelterController : ControllerBase
//  {
//    private static readonly string[] Summaries = new[]
//    {
//      "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//    }
//
//    private readonly ILogger<AnimalShelterController> _logger;
//
//    public AnimalShelterController(ILogger<AnimalShelterController> logger)
//    {
//      _logger = logger;
//    }
//
//    [HttpGet]
//    public IEnumerable<AnimalShelter> Get()
//    {
//      var rng = new Random();
//      return Enumerable.Range(1, 5).Select(index => new AnimalShelter
//      {
//        Date = DateTime.Now.AddDays(index),
//        TemperatureC = rng.Next(-20, 55),
//        Summary = Summaries[rng.Next(Summaries.Length)]
//      })
//      .ToArray();
//    }
//  }
//}
