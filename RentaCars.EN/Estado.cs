using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentaCars.EN
{
  public class Estado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int EstadoID { get; set; }
        [Required(ErrorMessage ="Campo no puede estar vacio")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Solo letras")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        public ICollection<Usuario> Usuario { get; set; }
        public ICollection<TipoUsuario> TipoUsuario { get; set; }
        public ICollection<Vehiculo> Vehiculo { get; set; }
        public ICollection<Reserva> Reserva { get; set; }
        public ICollection<Renta> Renta { get; set; }
    }
}
