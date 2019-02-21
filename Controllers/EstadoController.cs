using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiLocalidad.Models;

namespace WebApiLocalidad.Controllers
{
    [Produces("application/json")]
    [Route("api/Pais/{PaisId}/Provincia")]
    public class EstadoController : Controller
    {
        public  readonly ApplicationDbContext context;
        public EstadoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Estado> GetAll(int PaisId)
        {
            //Retorna todos los estados
            //return    context.Estados.ToList();
            
            //Retorna los estasdos del pais id
            return context.Estados.Where(x => x.PaisId == PaisId).ToList();

        }
    }
}