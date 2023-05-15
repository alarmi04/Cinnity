using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Cinnity
{
    class Pelicula
    {
        private string nombre;
        private string genero;
        private string director;
        private string reparto;
        private int duracionMinutos;
        private string sinopsis;
        private DateTime fechaEstreno;
        private Image caratula;

        public Image Caratula { get { return caratula; } set { caratula = value; } }
        public Pelicula(string nom, string gene, string direc, string repar, int dura, string sinop, DateTime estreno, Image carat)
        {
            nombre = nom;
            genero = gene;
            director = direc;
            reparto = repar;
            duracionMinutos = dura;
            sinopsis = sinop;
            fechaEstreno = estreno;
            caratula = carat;
        }

        public Pelicula() { }

        //añadir pelicula
        //eliminar pelicula
        //Busqueda por nombre
        //Busqueda por filtro


        public int AgregarPelicula(Pelicula pel)
        {

            int retorno;
            MemoryStream ms = new MemoryStream();
            pel.caratula.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Pelicula (fotoCaratula, nombrePeli, genero, director, reparto, duraccion, sinopsis, fechEstreno) " +
                    "VALUES (@caratula, @nombre, @genero, @director, @reparto, @duracionMinutos, @sinopsis, @fechaEstreno);";
                cmd.Parameters.AddWithValue("@caratula", aByte);
                cmd.Parameters.AddWithValue("@nombre", pel.nombre);
                cmd.Parameters.AddWithValue("@genero", pel.genero);
                cmd.Parameters.AddWithValue("@director", pel.director);
                cmd.Parameters.AddWithValue("@reparto", pel.reparto);
                cmd.Parameters.AddWithValue("@duracionMinutos", pel.duracionMinutos);
                cmd.Parameters.AddWithValue("@sinopsis", pel.sinopsis);
                cmd.Parameters.AddWithValue("@fechaEstreno", pel.fechaEstreno);

                retorno = cmd.ExecuteNonQuery();
            }

            return retorno;
        }


        public int ElminarPelicula(string nombre)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM Pelicula WHERE nombrePeli='{0}'", nombre);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<Pelicula> BuscarPelicula(string nombre)
        {
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = "SELECT * FROM Pelicula WHERE nombrePeli=" + nombre + ";";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();
                    peli.nombre = reader.GetString(2);
                    peli.genero = reader.GetString(3);
                    peli.director = reader.GetString(4);
                    peli.reparto = reader.GetString(5);
                    peli.duracionMinutos = reader.GetInt16(6);
                    peli.sinopsis = reader.GetString(7);
                    peli.fechaEstreno = reader.GetDateTime(8);

                    byte[] img = (byte[])(reader["fotoCaratula"]);


                    if (img != null)
                    {
                        try
                        {
                            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                            peli.caratula = (Image)converter.ConvertFrom(img);
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show("Error converting image: " + ex.Message);
                        }
                    }

                    lista.Add(peli);
                }
            }
            return lista;
        }

        public static List<Pelicula> CargarPeliculas()
        {
            List<Pelicula> lista = new List<Pelicula>();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Pelicula", ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();

                    byte[] img = (byte[])(reader["fotoCaratula"]);

                    if (img != null)
                    {
                        try
                        {
                            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                            peli.Caratula = (Image)converter.ConvertFrom(img);
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show("Error converting image: " + ex.Message);
                        }
                    }

                    lista.Add(peli);
                }
            }

            reader.Close();
            return lista;
        }

        public static List<Pelicula> FiltrarPelicula(string genero, string consulta)
        {
            List<Pelicula> lista = new List<Pelicula>();
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();

                    byte[] img = (byte[])(reader["fotoCaratula"]);

                    if (img != null)
                    {
                        try
                        {
                            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                            peli.Caratula = (Image)converter.ConvertFrom(img);
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show("Error converting image: " + ex.Message);
                        }
                    }

                    lista.Add(peli);
                }
            }

            reader.Close();
            return lista;
        }
    }
}



