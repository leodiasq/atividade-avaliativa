using System;
using System.Collections.Generic;
using System.Data;
using static atividade_avaliativa.desafio_Classe.Class1;

namespace SysTINSClass
{
    public class Produto
    {
        private object Banco;

        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public Categoria Categoria { get; set; }

        public Produto()
        {
            Categoria = new();
        }

        public 
            Produto(int id, string nome, decimal preco, int estoque, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
            Categoria = categoria;
        }

        // Inserir
        public void Inserir()
        {
            if (Estoque < 10) // Exemplo de regra de negócio para estoque mínimo
                throw new Exception("Estoque mínimo não pode ser menor que 10.");

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            cmd.Parameters.AddWithValue("spestoque", Estoque);
            cmd.Parameters.AddWithValue("spcategoria", Categoria.Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        // ObterPorId
        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDecimal(2),
                    dr.GetInt32(3),
                    Categoria.ObterPorId(dr.GetInt32(4))
                );
            }
            return produto;
        }

        public static List<Produto> ObterLista()
        {
            List<Produto> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from produtos order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDecimal(2),
                    dr.GetInt32(3),
                    Categoria.ObterPorId(dr.GetInt32(4))
                ));
            }
            return lista;
        }

        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sppreco", Preco);
            cmd.Parameters.AddWithValue("spestoque", Estoque);
            cmd.Parameters.AddWithValue("spcategoria", Categoria.Id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
