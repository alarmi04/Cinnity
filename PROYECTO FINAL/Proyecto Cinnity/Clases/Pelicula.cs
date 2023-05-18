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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Globalization;

namespace Proyecto_Cinnity
{
    class Pelicula
    {
        private int idPelicula;
        private string nombre;
        private string genero;
        private string director;
        private string reparto;
        private int duracionMinutos;
        private string sinopsis;
        private DateTime fechaEstreno;
        private Image caratula;

        public int IdPelicula { get { return idPelicula; } set { idPelicula = value; } }
        public Image Caratula { get { return caratula; } set { caratula = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Director { get { return director; } set { director = value; } }
        public string Reparto { get { return reparto; } set { reparto = value; } }
        public int DuracionMinutos { get { return duracionMinutos; } set { duracionMinutos = value; } }
        public string Sinopsis { get { return sinopsis; } set { sinopsis = value; } }
        public DateTime FechaEstreno { get { return fechaEstreno; } set { fechaEstreno = value; } }
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

        public static string BuscarInformacion(string asunto, string nombre)
        {
            string info = "";
            string consulta = "";
            if (asunto=="genero")
            {
                consulta = "SELECT genero from Pelicula WHERE nombrePeli='"+nombre+"';";
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        info = reader.GetString("genero");
                    }
                }
                reader.Close();

            }
            if (asunto == "director")
            {
                consulta = "SELECT director from Pelicula WHERE nombrePeli='" + nombre + "';";
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        info = reader.GetString("director");
                    }
                }
                reader.Close();

            }
            if (asunto == "reparto")
            {
                consulta = "SELECT reparto from Pelicula WHERE nombrePeli='"+nombre+"';";
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        info = reader.GetString("reparto");
                    }
                }
                reader.Close();

            }
            if (asunto == "nombre")
            {
                consulta = "SELECT nombrePeli from Pelicula WHERE nombrePeli='"+nombre+"';";
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        info = reader.GetString("nombrePeli");
                    }
                }
                reader.Close();

            }
            if (asunto == "duracion")
            {
                consulta = "SELECT duraccion from Pelicula WHERE nombrePeli='"+nombre+"';";
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        info = reader.GetString("duraccion");
                    }
                }
                reader.Close();

            }

            if (asunto == "sinopsis")
            {
                consulta = "SELECT sinopsis from Pelicula WHERE nombrePeli='"+nombre+"';";
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        info = reader.GetString("sinopsis");
                    }
                }
                reader.Close();

            }
            if (asunto == "fechaEstreno")
            {
                consulta = "SELECT fechaEstreno from Pelicula WHERE nombrePeli='"+nombre+"';";
                MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        info = reader.GetDateTime("fechaEstreno").ToString();
                    }
                }
                reader.Close();

            }
            return info;
        }

        public static byte[] CargarCaratula(string nombre)
        {
            string consulta = "SELECT fotoCaratula from Pelicula WHERE nombrePeli='" + nombre + "';";
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            byte[] img = null;
            if (reader.HasRows)
            {

                while (reader.Read())
                {
                   img = (byte[])(reader["fotoCaratula"]);

                }
            }
            reader.Close();
            return img;
        }

        public int ModificarPelicula(Pelicula pel)
        {

            int retorno;
            MemoryStream ms = new MemoryStream();
            pel.caratula.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Pelicula (fotoCaratula, nombrePeli, genero, director, reparto, duraccion, sinopsis, fechaEstreno) " +
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
        public int AgregarPelicula(Pelicula pel)
        {

            int retorno;
            MemoryStream ms = new MemoryStream();
            pel.caratula.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = ConexionBD.Conexion;
                cmd.CommandText = "INSERT INTO Pelicula (fotoCaratula, nombrePeli, genero, director, reparto, duraccion, sinopsis, fechaEstreno) " +
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

        public static Pelicula ObtenerPelicula(MySqlConnection conexion, string identificacion)
        {
            Pelicula peli = new Pelicula();
            string consulta = string.Format("SELECT * FROM pelicula WHERE nombrePeli='{0}'", identificacion);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                peli.idPelicula= Convert.ToInt32(reader["idPelicula"]);
                peli.nombre = reader.GetString(2);
                peli.genero = reader.GetString(3);
                peli.director = reader.GetString(4);
                peli.reparto = reader.GetString(5);
                peli.duracionMinutos = reader.GetInt16(6);
                peli.sinopsis = reader.GetString(7);
                peli.fechaEstreno = reader.GetDateTime(8);

                byte[] img = (byte[])reader["fotoCaratula"];
                MemoryStream ms = new MemoryStream(img);
                peli.Caratula = Image.FromStream(ms);

            }
            // Cerramos el reader para que luego se reutilice
            reader.Close();
            return peli;
        }

        public bool YaEsta(MySqlConnection conexion, string nom)
        {
            string consulta = string.Format("SELECT * FROM pelicula" +
            " WHERE nombrePeli='{0}';", nom);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            { // si existen registros en la devolución de la consulta
                reader.Close();   // Cierro el reader para utilizar la misma conexión en AgregarUsuario
                return true;
            }
            else
            {
                reader.Close();  // Cierro el reader para utilizar la misma conexión en AgregarUsuario
                return false;
            }

        }

        public int ActualizaPelicula(MySqlConnection conexion, Pelicula pel)
        {
            int retorno;

            // Preparación de la imagen
            MemoryStream ms = new MemoryStream();
            pel.Caratula.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = ms.ToArray();

            string consulta = string.Format("UPDATE pelicula SET nombrePeli='{0}',genero='{1}',director='{2}',reparto='{3}'," +
                "duraccion={4},sinopsis='{5}',fotoCaratula=@fotoCaratula WHERE nombrePeli='{6}'", pel.Nombre, pel.Genero, pel.Director, pel.Reparto, 
                pel.DuracionMinutos,pel.FechaEstreno.ToString("yyyy/MM/dd"), pel.Nombre);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("fotoCaratula", imgArr);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        public static List<Pelicula> BuscarPelicula(string nombre)
        {
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = "SELECT * FROM Pelicula WHERE nombrePeli='" + nombre + "';";
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

        public static int RecogerID(string titulo)
        {
            string consulta = "SELECT idPelicula from Pelicula WHERE nombrePeli='" + titulo + "';";
            int id = -1;
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            reader.Close();
            return id;

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



