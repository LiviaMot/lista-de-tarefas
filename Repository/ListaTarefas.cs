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
    tarefas[idAlterar].PersoData = persoData;
    tarefas[idAlterar].PersoHora = persoHora;
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