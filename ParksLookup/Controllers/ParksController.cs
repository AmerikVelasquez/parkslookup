using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksLookup.Models;
using System.Linq;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController :ControllerBase
  {
    private readonly ParksLookupContext _db;
    public ParksController(ParksLookupContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      var query = _db.Parks.AsQueryable();
      return query.ToList();
    }
  }
}