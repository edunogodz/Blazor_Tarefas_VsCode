using Blazor_Tarefas.Entities;

namespace Blazor_Tarefas.Repositorio;
public interface IRepositorio
{
    List<Tarefa> ObterTarefas();
}