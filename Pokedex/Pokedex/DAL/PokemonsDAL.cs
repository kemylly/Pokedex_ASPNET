using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace Pokedex.DAL
{
    public class PokemonsDAL
    {
        Connection con = new Connection();

        public int CadastrarPokemon(BLL.PokemonsBLL a)
        {
            int ChaveGerada = 0;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = "INSERT INTO TBPokemons (Nome, Tipo, Descricao) VALUES (@nome, @tipo, @descricao); SELECT SCOPE_IDENTITY() AS ChaveGerada";

            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@tipo", a.Tipo);
            cmd.Parameters.AddWithValue("@descricao", a.Descricao);

            ChaveGerada = Convert.ToInt32(cmd.ExecuteScalar());

            //cmd.ExecuteNonQuery();
            con.Desconectar();

            return ChaveGerada;
        }
    }
}