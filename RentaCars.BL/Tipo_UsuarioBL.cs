using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using RentaCars.EN;
using RentaCars.DAL;

namespace RentaCars.BL
{
    public class Tipo_UsuarioBL
    {
        private Tipo_UsuarioDAL DAL = new Tipo_UsuarioDAL();

        public int InserTipo_Usuario(TipoUsuario Tipo)
        {
            return DAL.AddTipo_Usuario(Tipo);
        }
        public List<TipoUsuario> Tipo_UsuarioList(string state)
        {
            return DAL.Tipo_UsuarioList(state);
        }
        public int UpdateTipo_Usuario(TipoUsuario Tipo)
        {
            return DAL.UpdateTipo_Usuario(Tipo);
        }
        public int DeleteTipo_Usuario(int id)
        {
            return DAL.DeleteTipo_Usuario(id);
        }
        public TipoUsuario FindTipo_Usuario(int id)
        {
            return DAL.FindTipo_Usuario(id);
        }
    }
}
