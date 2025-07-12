namespace std;

public class ControllerListaTarefas {
  public static void CriarTarefas(
    string nomeTarefa,
    string persoData,
    string persoHora
  ) {
    var novaTarefa = new ListaTarefas(nomeTarefa, persoData, persoHora);
    RepositoryListaTarefas.CriarTarefas(novaTarefa);
  }
  public static List<ListaTarefas> ListarTarefas() {
    return RepositoryListaTarefas.ListaTarefas();
  }
  public static void AlterarTarefas(int idAlterar, string nomeTarefa, string persoData, string persoHora) {
    RepositoryListaTarefas.AlterarTarefas(idAlterar, nomeTarefa, persoData, persoHora);
  }
  public static void ModificarStatus(int index, bool concluido) {
    RepositoryListaTarefas.ModificarStatus(index, concluido);
  }
  public static void DeletarTarefas(int idDeletar) {
    RepositoryListaTarefas.DeletarTarefas(idDeletar);
  }
}