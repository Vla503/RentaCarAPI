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
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int UsuarioID { get; set; }
        [Display(Name = "Id Tipo Usuario")]
        public int TipoUsuarioID { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Telefono")]
        public int Telefono { get; set; }
        [Display(Name = "Nombre Usuario")]
        public string NombreUser { get; set; }
        [Display(Name = "Contraseña")]
        public string Pass { get; set; }
        [Display(Name = "Estado id")]
        public int EstadoID { get; set; }


        public  TipoUsuario TipoUsuario { get; set; }
        public  Estado Estado { get; set; }
        public  ICollection<Vehiculo> Vehiculo { get; set; }
        public  ICollection<Renta> Renta { get; set; }

    }
}
