namespace std;

public class ListaTarefas {
  // Atributos
  public string NomeTarefa { get; set; }
  public string PersoData { get; set; }
  public string PersoHora { get; set; }
  public bool Concluido { get; set; } // false = não concluído

  public ListaTarefas(
    string nomeTarefa,
    string persoData,
    string persoHora
    )
  {
    NomeTarefa = nomeTarefa;
    PersoData = persoData;
    PersoHora = persoHora;
    Concluido = false;
  }

  // Métodos
  public void MostrarTarefas() {
    string status = Concluido ? "Concluído" : "Não Concluído";
    Console.WriteLine($"{NomeTarefa} no dia {PersoData} às {PersoHora} - {status}.");
  }
}