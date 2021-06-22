using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vaccination.SqlServerContext;

namespace Vaccination
{
    public partial class FrmCitizen : Form
    {
        public FrmCitizen()
        {
            InitializeComponent();
        }

        private void FrmCitizen_Load(object sender, EventArgs e)
        {
            var db = new Proyecto_DB_POOContext();
            List<Disease> diseases = db.Diseases
                .ToList();
            cmbDisease.DataSource = diseases;
            cmbDisease.DisplayMember = "DiseaseName";
            cmbDisease.ValueMember = "Id";
            
            List<Charge> charges = db.Charges
                .ToList();
            cmbCharge.DataSource = charges;
            cmbCharge.DisplayMember = "NameCharge";
            cmbCharge.ValueMember = "Id";
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {

                var db = new Proyecto_DB_POOContext();
                
                Citizen citizen = new Citizen()
                {
                    Dui = txtDui.Text,
                    FullName = txtName.Text,
                    Age = Convert.ToInt32(this.txtAge.Text),
                    CitizenAddress = txtAddres.Text,
                    PhoneNumber = txtPhoneNum.Text,
                    Email = txtEmail.Text,
                    IdDisease = ((Disease)cmbDisease.SelectedItem).Id,
                    IdCharge = ((Charge)cmbCharge.SelectedItem).Id
                };

                bool Very = txtDui.Text.Length == 0 || txtName.Text.Length == 0 || txtAddres.Text.Length == 0 || txtAge.Text.Length == 0 || txtEmail.Text.Length == 0 ;
                if (Very )
                {
                    MessageBox.Show("Debe llenar los campos Obligatorios", "Sistema de registro - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.Add(citizen);
                    db.SaveChanges();
                    MessageBox.Show("Ciudadano registrado!!!", "Sistema de registro - Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    

                }

                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
