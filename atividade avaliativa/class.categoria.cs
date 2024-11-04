using System;
using System.Collections.Generic;
using System.Data;

namespace SysTINSClass
{
    public class Categoria
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public Categoria() { }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        // Inserir
        public void Inserir()
        {
            using var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome ?? string.Empty);
            cmd.ExecuteNonQuery();
        }

        // ObterPorId
        public static Categoria ObterPorId(int id)
        {
            using var cmd = Banco.Abrir();
            cmd.CommandText = "SELECT * FROM categorias WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            using var dr = cmd.ExecuteReader();
            return dr.Read() ? new Categoria(dr.GetInt32(0), dr.GetString(1)) : null;
        }

        // ObterLista
        public static List<Categoria> ObterLista()
        {
            var lista = new List<Categoria>();
            using var cmd = Banco.Abrir();
            cmd.CommandText = "SELECT * FROM categorias ORDER BY nome ASC";
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Categoria(dr.GetInt32(0), dr.GetString(1)));
            }
            return lista;
        }

        // Atualizar
        public bool Atualizar()
        {
            using var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome ?? string.Empty);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
