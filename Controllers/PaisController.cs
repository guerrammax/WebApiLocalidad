using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiLocalidad.Models;

namespace WebApiLocalidad.Controllers
{
    [Produces("application/json")]
    [Route("api/Pais")]
    public class PaisController : Controller
    {
        private readonly ApplicationDbContext context;
        public PaisController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Pais> Get(){
            return context.Paises.ToList();
        }
    }
}