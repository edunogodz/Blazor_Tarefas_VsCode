using Blazor_Tarefas.Entities;

namespace Blazor_Tarefas.Repositorio;

public class Repositorio : IRepositorio
{
    public List<Tarefa> ObterTarefas()
    {
        return new List<Tarefa>()
       {
         new Tarefa
         {
            ID = new Guid(),
            Descricao = "Blazor course",
            Concluida = false,
            DataCriacao= Convert.ToDateTime("2019-09-11")
         },
          new Tarefa
         {
            ID = new Guid(),
            Descricao = "Study Blazor",
            Concluida = false,
            DataCriacao= Convert.ToDateTime("2019-09-05")
         },
       };
    }
}