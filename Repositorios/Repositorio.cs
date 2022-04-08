using Blazor_Tarefas.Entidades;
using System;
using System.Collections.Generic;

namespace Blazor_Tarefas.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Tarefa> ObterTarefas()
        {
            return new List<Tarefa>()
            {
                new Tarefa
                {
                    Id = new Guid("dc44adff-557c-4106-80f2-db799e33dc20"),
                    Descricao = "Fazer o curso de Blazor",
                    Concluida = false,
                    DataCriacao = Convert.ToDateTime("2022-04-08")
                },
                new Tarefa
                {
                    Id = new Guid("e6cc5261-840f-470a-a451-6712c4435eee"),
                    Descricao = "Estudar Blazor",
                    Concluida = false,
                    DataCriacao = Convert.ToDateTime("2022-04-03")
                }
            };
        }
    }
}
