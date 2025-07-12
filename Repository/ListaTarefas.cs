namespace std;

public class RepositoryListaTarefas {
  static List<ListaTarefas> tarefas = new List<ListaTarefas>();
  public static void CriarTarefas(ListaTarefas tarefa) {
    tarefas.Add(tarefa);
  }
  public static List<ListaTarefas> ListaTarefas() {
    return tarefas;
  }
  public static void AlterarTarefas(
    int idAlterar,
    string nomeTarefa,
    string persoData,
    string persoHora
    ) {
    if (tarefas[idAlterar] == null) return;
    tarefas[idAlterar].NomeTarefa = nomeTarefa;

    try {
      tarefas[idAlterar].AgendadaPara = DateTime.ParseExact(
        $"{persoData}/{DateTime.Now.Year} {persoHora}",
        "dd/MM/yyyy HH:mm",
        null
      );
    }
    catch {
      Console.WriteLine("Data ou hora inválida. A tarefa foi atualizada apenas no nome.");
    }
  }
  public static void ModificarStatus(int index, bool concluido) {
    if (tarefas[index] != null) {
      tarefas[index].Concluido = concluido;
    }
  }
  public static void DeletarTarefas(int idDeletar) {
    tarefas.RemoveAt(idDeletar);
  }
}