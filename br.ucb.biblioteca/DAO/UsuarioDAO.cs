using br.ucb.biblioteca.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.ucb.biblioteca.DAO
{
    /// <summary>
    /// Classe responsável por acesso ao banco de dados
    /// e tabela Usuario
    /// </summary>
    internal class UsuarioDAO
    {
        /// <summary>
        /// Método responsável pelo login do usuário
        /// </summary>
        /// <param name="dto">UsuarioDTO</param>
        /// <returns>true/false</returns>
        internal bool loginUsuario(UsuarioDTO dto)
        {
            if (String.IsNullOrEmpty(dto.nomeUsuario))
                return false;

            return true;
        }
    }
}
