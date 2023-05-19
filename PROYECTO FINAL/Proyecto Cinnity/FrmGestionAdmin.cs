using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Cinnity.RecursosLocalizables;
using System.Globalization;
using System.Threading;

namespace Proyecto_Cinnity
{
    public partial class FrmGestionAdmin : Form
    {
        public FrmGestionAdmin()
        {
            InitializeComponent();
        }

        private void AplicarIdioma()
        {
            lblId.Text = StringRecursos.idPeli;
            lblTítulo.Text = StringRecursos.titulopel;
            lblDirector.Text = StringRecursos.directorAdmin;
            lblGenero.Text = StringRecursos.generoAdmin;
            lblDuracion.Text = StringRecursos.duracionAdmin;
            lblReparto.Text = StringRecursos.repartoAdmin;
            lblFechaEstreno.Text = StringRecursos.fechaestrenoAdmin;
            lblSinopsis.Text = StringRecursos.sinopsisAdmin;
            btnCargarImagen.Text = StringRecursos.selecImagenAdmin;
            lblInformacion.Text = StringRecursos.ClickAdmin;
            btnLimpiar.Text = StringRecursos.limpiarAdmin;
            btnModificar.Text = StringRecursos.modificarAdmin;
            btnAgregar.Text = StringRecursos.agregarAdmin;
            this.Text = StringRecursos.tituloVentanaGestionAdmin;
            Thread.CurrentThread.CurrentUICulture = idioma.CulturaActual;
        }

        public void CargarDataGrid()
        {
            List<Pelicula> lista = Pelicula.CargarPeliculas();
            dgvPeliculas.DataSource = lista;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdSeleccionar.Title = "Seleccionar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void LimpiarControles()
        {
            txtTitulo.Clear();
            txtGenero.Clear();
            txtDirector.Clear();
            txtReparto.Clear();
            nudDuracion.Value = 0;
            dtpFechaEstreno.Value = DateTime.Now;
            txtSinopsis.Clear();
            ptbImagen.Image = null;
            txtId.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    Pelicula pel = new Pelicula();
                    pel.Nombre = txtTitulo.Text;
                    pel.Genero = txtGenero.Text;
                    pel.Director = txtDirector.Text;
                    pel.Reparto = txtReparto.Text;
                    pel.DuracionMinutos = (int)nudDuracion.Value;
                    pel.Sinopsis = txtSinopsis.Text;
                    pel.FechaEstreno = dtpFechaEstreno.Value;
                    pel.Caratula = ptbImagen.Image;

                    if (String.IsNullOrEmpty(txtId.Text))  // Estoy agregando un usuario nuevo
                    {
                        if (pel.YaEsta(ConexionBD.Conexion, pel.Nombre))  // Comprobamos si existe el usuario
                        {
                            MessageBox.Show("Esta película no se puede dar de alta. Ya existe");
                        }
                        else
                        {
                            resultado = pel.AgregarPelicula(pel);
                        }
                    }
                    else // Estoy modificando un usuario editado
                    {
                        pel.IdPelicula = Convert.ToInt16(txtId.Text);
                        resultado = pel.ActualizaPelicula(pel);
                    }

                    if (resultado > 0) // Si se ha agregado o modificado limpiamos las cajas de texto
                    {
                        LimpiarControles();
                    }
                    CargarDataGrid();
                    // Cierro la conexión
                    ConexionBD.CerrarConexion();
                    // volvemos a cargar toda la lista de usuarios;


                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                ConexionBD.CerrarConexion();
            }
        }

        private void btnMiPerfil_Click(object sender, EventArgs e)
        {
            FrmMiPerfil frm1 = new FrmMiPerfil();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            FrmPaginaPrincipal frm1 = new FrmPaginaPrincipal();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioDeSesion frm1 = new FrmInicioDeSesion();
            this.Hide();
            frm1.StartPosition = FormStartPosition.CenterScreen;

            frm1.Show();
        }

        private bool DatosValidos()
        {
            bool ok = true;

            errorGestionAdmin.Clear();

            if (txtTitulo.Text == "")
            {
                ok = false;
                errorGestionAdmin.SetError(txtTitulo, "Introduce un título.");
            }

            if (txtGenero.Text == "")
            {
                ok = false;
                errorGestionAdmin.SetError(txtGenero, "Introduce un genero.");
            }

            if (txtDirector.Text == "")
            {
                ok = false;
                errorGestionAdmin.SetError(txtDirector, "Introduce un director.");
            }

            if (txtReparto.Text == "")
            {
                ok = false;
                errorGestionAdmin.SetError(txtReparto, "Introduce un reparto.");
            }

            if (nudDuracion.Value == 0)
            {
                ok = false;
                errorGestionAdmin.SetError(nudDuracion, "Introduce una duración.");
            }

            if (txtSinopsis.Text == "")
            {
                ok = false;
                errorGestionAdmin.SetError(txtSinopsis, "Introduce una sinopsis.");
            }

            if (ptbImagen.Image == null)
            {
                ok = false;
                errorGestionAdmin.SetError(ptbImagen, "Introduce una imagen.");
            }
            return ok;

        }

        private void FrmGestionAdmin_Load(object sender, EventArgs e)
        {

            if (ConexionBD.Conexion != null)
            {
                try
                {
                    ConexionBD.AbrirConexion();
                    AplicarIdioma();
                    CargarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    ConexionBD.CerrarConexion();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPeliculas.SelectedRows.Count == 1) // Si hay una fila seleccionada en el datagridview
                {
                    string titulo = dgvPeliculas.CurrentRow.Cells[0].Value.ToString();  // Obtenemos el id de la fila seleccionada
                    // Extraigo de la BD la información (no del datagrid!) 
                    // por si estuviese actualizada en la BD por otro usuario y no estuviese refrescada en mi datagridview
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        Pelicula pel = Pelicula.ObtenerPelicula(ConexionBD.Conexion, titulo);
                        CargaCajasTexto(pel);

 
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }
                    // Cerramos la conexion
                    ConexionBD.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }

        private void CargaCajasTexto(Pelicula pel)
        {
            txtTitulo.Text = pel.Nombre.ToString();
            txtGenero.Text = pel.Genero;
            txtDirector.Text = pel.Director;
            txtReparto.Text = pel.Reparto;
            nudDuracion.Value = pel.DuracionMinutos;
            dtpFechaEstreno.Value = pel.FechaEstreno;
            txtSinopsis.Text = pel.Sinopsis;
            ptbImagen.Image = pel.Caratula;
            txtId.Text = pel.IdPelicula.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
