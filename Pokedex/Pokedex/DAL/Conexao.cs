using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace Pokedex.DAL
{
    public class Connection
    {
       
        SqlConnection con;

        public Connection()
        {
            con = new SqlConnection();
            /*con.ConnectionString = @"Data Source=(local)\sql;
                                     Initial Catalog=BDPokemon;
                                     Integrated Security=true";*/

            con.ConnectionString = @"Data Source=(local)\sqlexpress;
                                    Initial Catalog=BDPokemon;
                                    Integrated Security=true";
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
}