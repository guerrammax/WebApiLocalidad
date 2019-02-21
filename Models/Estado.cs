using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiLocalidad.Models
{
    public class Estado
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
        
    }
}