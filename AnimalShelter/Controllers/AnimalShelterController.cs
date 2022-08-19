using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AnimalShelter.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }
  

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()

    {
      return await _db.Animals.ToListAsync();
    }
  }
}
