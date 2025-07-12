namespace std;

public class Program {
  public static void Main() {
    int op;
    Console.WriteLine("Bem vindo(a) ao App de Metas!");
    do {
      Console.WriteLine("Digite a opção Desejada: ");
      Console.WriteLine("1 - Criar tarefa");
      Console.WriteLine("2 - Listar tarefa");
      Console.WriteLine("3 - Alterar tarefa");
      Console.WriteLine("4 - Modificar Status");
      Console.WriteLine("5 - Deletar tarefa");
      Console.WriteLine("6 - Sair");
      Console.Write("-> ");
      op = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("");
      
      switch (op) {
        case 1 : {
          ViewListaTarefas.CriarTarefas();
          break;
        }
        case 2 : {
          ViewListaTarefas.ListarTarefas();
          break;
        }
        case 3 : {
          ViewListaTarefas.AlterarTarefas();
          break;
        }
        case 4 : {
            ViewListaTarefas.ModificarStatus();
          break;
        }
        case 5: {
          ViewListaTarefas.DeletarTarefas();
          break;
        }
        case 6 : {
          Console.WriteLine("Saindo do Programa!");
          break;
        }
        default: {
          break;
        }
      }
    } while (op != 6);
  }
}