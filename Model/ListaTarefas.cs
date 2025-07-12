namespace std;

public class ListaTarefas {
  // Atributos
  public string NomeTarefa { get; set; }
  public bool Concluido { get; set; } // false = não concluído
  public DateTime AgendadaPara { get; set; }

  public ListaTarefas(
    string nomeTarefa,
    string persoData,
    string persoHora
    )
  {
    NomeTarefa = nomeTarefa;
    Concluido = false;

    try {
      int anoAtual = DateTime.Now.Year;
      AgendadaPara = DateTime.ParseExact($"{persoData}/{anoAtual} {persoHora}", "dd/MM/yyyy HH:mm", null);
    } catch {
      Console.WriteLine("Data ou hora inválida. Tarefa não criada corretamente.");
      AgendadaPara = DateTime.MinValue;
    }
  }

  // Métodos
  public void MostrarTarefas() {
    string status = Concluido ? "Concluído" : "Não Concluído";
    string data = AgendadaPara.ToString("dd/MM");
    string hora = AgendadaPara.ToString("HH:mm");
    Console.WriteLine($"{NomeTarefa} no dia {data} às {hora} - {status}.");
  }
}