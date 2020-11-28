using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CasaDeMusica.Models;

namespace CasaDeMusica.GestorDatos
{
    public class GestorDatos
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public GestorDatos()
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            dr = null;
        }

        public void agregarinstrumento(Instrumento i)
        {
            con.ConnectionString = @"Data Source=BLACKHORDENOT;Initial Catalog=casademusica;Integrated Security=True";
            try
            {
                string consultasql = @"insert into instrumentos(nombre, descripcion, stock, precio, idTipo) values(@nombre, @descripcion, @stock, @precio, @idtipo)";
                con.Open();
                cmd = new SqlCommand(consultasql, con);

                cmd.Parameters.AddWithValue("@nombre", i.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", i.Descripcion);
                cmd.Parameters.AddWithValue("@stock", i.Stock);
                cmd.Parameters.AddWithValue("@precio", i.Precio);
                cmd.Parameters.AddWithValue("@idtipo", i.Idtipo);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
        public List<Tipo> listadetipos()
        {
            con.ConnectionString = @"Data Source=BLACKHORDENOT;Initial Catalog=casademusica;Integrated Security=True";
            string consultasql = @"select * from tipos";
            con.Open();
            cmd = new SqlCommand(consultasql, con);
            dr = cmd.ExecuteReader();
            List<Tipo> lista = new List<Tipo>();
            while (dr.Read())
            {
                Tipo t = new Tipo();
                t.Idtipo = int.Parse(dr["idTipo"].ToString());
                t.Nombre = dr["nombre"].ToString();
                lista.Add(t);
            }
            dr.Close();
            con.Close();
            return lista;
        }
        public List<Instrumento> listadeinstrumentos()
        {
            con.ConnectionString = @"Data Source=BLACKHORDENOT;Initial Catalog=casademusica;Integrated Security=True";
            string consultasql = @"select * from instrumentos";
            con.Open();
            cmd = new SqlCommand(consultasql, con);
            dr = cmd.ExecuteReader();
            List<Instrumento> lista = new List<Instrumento>();
            while (dr.Read())
            {
                Instrumento i = new Instrumento();
                i.Idinstrumento = int.Parse(dr["idInstrumento"].ToString());
                i.Nombre = dr["nombre"].ToString();
                i.Descripcion = dr["descripcion"].ToString();
                i.Stock = int.Parse(dr["stock"].ToString());
                i.Precio = double.Parse(dr["precio"].ToString());
                i.Idtipo = int.Parse(dr["idTipo"].ToString());
                lista.Add(i);
            }
            dr.Close();
            con.Close();
            return lista;
        }
        public Instrumento buscarinstrumento(int idinstrumento)
        {
            con.ConnectionString = @"Data Source=BLACKHORDENOT;Initial Catalog=casademusica;Integrated Security=True";
            string consultasql = @"select * from instrumentos where idInstrumento = @idinstrumento";
            con.Open();
            cmd = new SqlCommand(consultasql, con);
            cmd.Parameters.AddWithValue("@idinstrumento", idinstrumento);
            dr = cmd.ExecuteReader();
            dr.Read();
            Instrumento i = new Instrumento();
            i.Idinstrumento = int.Parse(dr["idInstrumento"].ToString());
            i.Nombre = dr["nombre"].ToString();
            i.Descripcion = dr["descripcion"].ToString();
            i.Stock = int.Parse(dr["stock"].ToString());
            i.Precio = double.Parse(dr["precio"].ToString());
            i.Idtipo = int.Parse(dr["idTipo"].ToString());
            dr.Close();
            con.Close();
            return i;
        }
        public void actualizarinstrumento(Instrumento i)
        {
            con.ConnectionString = @"Data Source=BLACKHORDENOT;Initial Catalog=casademusica;Integrated Security=True";
            string consultasql = @"update instrumentos
                                    set nombre=@nombre,
	                                    descripcion=@descripcion,
	                                    stock=@stock,
	                                    precio=@precio,
	                                    idtipo=@idtipo
	                                    where idInstrumento=@idintrumento";
            con.Open();
            cmd = new SqlCommand(consultasql, con);
            cmd.Parameters.AddWithValue("@nombre", i.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", i.Descripcion);
            cmd.Parameters.AddWithValue("@stock", i.Stock);
            cmd.Parameters.AddWithValue("@precio", i.Precio);
            cmd.Parameters.AddWithValue("@idtipo", i.Idtipo);
            cmd.Parameters.AddWithValue("@idintrumento", i.Idinstrumento);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}