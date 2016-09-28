using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//importes
using br.ucb.biblioteca.DTO;
using br.ucb.biblioteca.Model;

namespace WindowsFormsClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLogar_Click(object sender, EventArgs e)
        {
            UsuarioDTO dto = new UsuarioDTO();
            dto.nomeUsuario = txtNome.Text;
            dto.senhaUsuario = txtSenha.Text;

            UsuarioModel model = new UsuarioModel();
            if (model.loginUsuario(dto)) 
            {
                MessageBox.Show("Usuario ou senha válidos");
            }
            else
                MessageBox.Show("Usuario ou senha inválidos");

        }
    }
}
