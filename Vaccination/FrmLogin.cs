using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Vaccination.SqlServerContext;
using Vaccination.SqlServerContext;

namespace Vaccination
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnStartSesion_Click(object sender, EventArgs e)
        {
            string User = txtUser.Text;
            string Password = txtPassword.Text;

            var db = new Proyecto_DB_POOContext();
            var ListUsers = db.Managers
                .OrderBy(ma => ma.Id)
                .ToList();

            var result = ListUsers.Where(
                    m => m.Username.Equals(txtUser.Text) &&
                         m.PasswordManager.Equals(txtPassword.Text))
                .ToList();

            if (result.Count == 0)
                MessageBox.Show("No se encontro ningun Manager con estos datos", "Inicio de sesion-ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                MessageBox.Show("Bienvenido " + txtUser.Text, "Inicio de sesion - Bienvenido/a", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


        }
    }
}