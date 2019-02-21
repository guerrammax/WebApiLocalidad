using System.ComponentModel.DataAnnotations;

namespace WebApiLocalidad.Models
{
    public class Pais
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
    }
}