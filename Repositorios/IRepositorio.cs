using Blazor_Tarefas.Entidades;
using System.Collections.Generic;

namespace Blazor_Tarefas.Repositorios
{
    public interface IRepositorio
    {
        List<Tarefa> ObterTarefas();
    }
}
