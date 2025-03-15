using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class frmPasajeros : Form
    {
        public frmPasajeros()
        {
            InitializeComponent();
        }


        public void EliminarPasajero(Pasajero pPasajero)
        {
            try
            {
                using (BD_LATAMEntities bd = new BD_LATAMEntities())
                {
                    var pasajeros = from p in bd.Pasajero
                                    where p.Id == pPasajero.Id
                                    select p;

                    foreach (Pasajero pas in pasajeros)
                    {
                        bd.Pasajero.Remove(pas);
                    }

                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarPasajero(Pasajero pPasajero)
        {
            try
            {
                using (BD_LATAMEntities bd = new BD_LATAMEntities())
                {
                    var pasajeros = from p in bd.Pasajero
                                    where p.Id == pPasajero.Id
                                    select p;

                    foreach (Pasajero pas in pasajeros)
                    {
                        pas.Nombres = pPasajero.Nombres;
                        pas.ApellidoPaterno = pPasajero.ApellidoPaterno;
                        pas.ApellidoMaterno = pPasajero.ApellidoMaterno;
                        pas.Dni = pPasajero.Dni;
                        pas.Activo = pPasajero.Activo;
                    }

                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void frmPasajeros_Load(object sender, EventArgs e)
        {
            Pasajero pasajero = new Pasajero();
            pasajero.Id = 5;
            //pasajero.Nombres = "Martha";
            //pasajero.ApellidoPaterno = "Zegarra";
            //pasajero.ApellidoMaterno = "Terrones";
            //pasajero.Dni = "987654321";
            //pasajero.Activo = false;

            //InsertarPasajero(pasajero);
            //ActualizarPasajero(pasajero);
            EliminarPasajero(pasajero);
            dgvPasajeros.DataSource = ObtenerPasajeros();



        }

        public void InsertarPasajero(Pasajero pPasajero)
        {
            try
            {
                using (BD_LATAMEntities bd = new BD_LATAMEntities())
                {
                    bd.Pasajero.Add(pPasajero);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<PasajeroDto> ObtenerPasajeros()
        {
            try
            {
                using (BD_LATAMEntities bd = new BD_LATAMEntities())
                {
                    var consulta = (from n in bd.Pasajero
                                    select new PasajeroDto
                                    {
                                        Id = n.Id,
                                        Nombres = n.Nombres,
                                        ApellidoPaterno = n.ApellidoPaterno,
                                        ApellidoMaterno = n.ApellidoMaterno,
                                        Dni = n.Dni,
                                        Activo = n.Activo

                                    }).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
