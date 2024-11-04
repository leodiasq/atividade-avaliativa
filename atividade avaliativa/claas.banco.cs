using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_avaliativa
{
    internal class Claas;
    namespace desafio_Classe
    {
        public class Class1
        {
            public class Categoria
            {
                public int Id { get; set; }
                public required string Nome { get; set; }

                // Método para inserir categoria
                public void Inserir(Categoria categoria)
                {
                    // Implementar a lógica para inserir no banco de dados
                }


                // Método para atualizar categoria
                public void Atualizar(Categoria categoria)
                {
                    // Implementar a lógica para atualizar no banco de dados
                }

                internal Categoria ObterPorId(int v)
                {
                    throw new NotImplementedException();
                }
            }

            public class Produto
            {
                public int Id { get; set; }
                public required string Nome { get; set; }
                public decimal Preco { get; set; }
                public int Estoque { get; set; }
                public int CategoriaId { get; set; }

                private const int EstoqueMinimo = 10;

                // Método para inserir produto
                public void Inserir(Produto produto)
                {
                    if (produto.Estoque < EstoqueMinimo)
                    {
                        throw new Exception("Estoque mínimo deve ser respeitado.");
                    }
                    // Implementar a lógica para inserir no banco de dados
                }

                // Método para listar produtos
                public static List<Produto> Listar()
                {
                    
                }

                // Método para consultar um produto
                public static Produto Consultar(int id)
                {
                   
                }

                // Método para atualizar produto
                public void Atualizar(Produto produto)
                {
                    if (produto.Estoque < EstoqueMinimo)
                    {
                        throw new Exception("Estoque mínimo deve ser respeitado.");
                    }
                    
                }
            }

        }
    }
}

