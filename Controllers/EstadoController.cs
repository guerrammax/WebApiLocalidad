using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{id}", Name="estadoById")]
        public IActionResult GetById(int id){
            var pais = context.Estados.FirstOrDefault(x=>x.Id == id);

            if (pais==null)
            {
                return NotFound();
            }

            return new ObjectResult(pais);

        }

        [HttpPost]
        public IActionResult Create([FromBody] Estado estado, int idPais)
        {
            estado.PaisId =idPais;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Estados.Add(estado);
            context.SaveChanges();

            return new CreatedAtRouteResult("provinciaById", new {id = estado.Id}, estado);
       
        }
        
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Estado estado, int id){
            if (estado.Id != id)
            {
                return BadRequest();
            }

            context.Entry(estado).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var estado = context.Estados.FirstOrDefault(x=>x.Id == id);
            if (estado == null)
            {
                return NotFound();
            }
            context.Estados.Remove(estado);
            context.SaveChanges();
            return Ok(estado);
        }
    }
}