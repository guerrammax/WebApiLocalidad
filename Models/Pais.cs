using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiLocalidad.Models
{
    public class Pais
    {
        public Pais()
        {
           Estados = new List<Estado>(); 
        }
        public int Id { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }

        public List<Estado> Estados { get; set; }
    }
}