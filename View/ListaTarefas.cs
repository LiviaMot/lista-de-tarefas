namespace std;

public class ViewListaTarefas {
  public static void CriarTarefas() {
    Console.Write("Digite a Tarefa: ");
    string nomeTarefa = Console.ReadLine() ?? "";
    Console.Write("Digite a data para concluir a tarefa (dd/mm): ");
    string persoData = Console.ReadLine() ?? "";
    Console.Write("Digite o horário para conclusão (hh:mm): ");
    string persoHora = Console.ReadLine() ?? "";

    ControllerListaTarefas.CriarTarefas(nomeTarefa, persoData, persoHora);
    Console.WriteLine("Tarefa Criada com sucesso!");
  }

  public static void ListarTarefas() {
    List<ListaTarefas> tarefas = ControllerListaTarefas.ListarTarefas();
    Console.WriteLine("===== Listando as Tarefas =====");
    foreach (ListaTarefas tarefa in tarefas) {
      tarefa.MostrarTarefas();
    }
    Console.WriteLine("===============================");
  }

  public static void AlterarTarefas() {
    Console.Write("Informe o INDEX da Tarefa para Alterar: ");
    int idAlterar = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite a Tarefa: ");
    string nomeTarefa = Console.ReadLine() ?? "";
    Console.Write("Digite a data para concluir a tarefa (dd/mm): ");
    string persoData = Console.ReadLine() ?? "";
    Console.Write("Digite o horário para conclusão (hh:mm): ");
    string persoHora = Console.ReadLine() ?? "";

    ControllerListaTarefas.AlterarTarefas(idAlterar, nomeTarefa, persoData, persoHora);
    Console.WriteLine("Tarefa Alterada com sucesso!");
  }
  public static void ModificarStatus()
  {
    Console.Write("Informe o INDEX da Tarefa para Alterar o Status: ");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.Write("Marcar como concluída? (s/n):");
    string resposta = Console.ReadLine() ?? "";
    bool concluido = (resposta == "s");

    ControllerListaTarefas.ModificarStatus(index, concluido);
    Console.WriteLine("Status da Tarefa modificada com sucesso!");
  }
  public static void DeletarTarefas() {
    Console.Write("Informe o INDEX da Tarefa para deletar: ");
    int idDeletar = Convert.ToInt32(Console.ReadLine());
    ControllerListaTarefas.DeletarTarefas(idDeletar);
    Console.WriteLine("Deletado com sucesso!");
  }
}