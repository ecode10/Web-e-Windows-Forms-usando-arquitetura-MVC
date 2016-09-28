using br.ucb.biblioteca.DAO;
using br.ucb.biblioteca.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.ucb.biblioteca.Model
{
    public class UsuarioModel 
    {
        private UsuarioDAO _dao;

        public UsuarioModel()
        {
            if (_dao == null)
                _dao = new UsuarioDAO();
        }

        public bool loginUsuario(UsuarioDTO dto)
        {
            return _dao.loginUsuario(dto);

        }
    }
}
