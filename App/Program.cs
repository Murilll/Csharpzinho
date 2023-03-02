Alunos aluno1 = new Alunos("AAAA", "13174780967", "25/08/2004", 60, 80, 90);
Alunos aluno2 = new Alunos("BBBB", "32454365487", "05/02/2000", 70, 40, 90);
Alunos aluno3 = new Alunos("CCCC", "87654365487", "20/03/1990", 20, 90, 90);
Alunos aluno4 = new Alunos("DDDD", "23465487632", "10/05/2003", 29, 100, 90);
Alunos aluno5 = new Alunos("EEEE", "13243543767", "11/07/2002", 80, 40, 90);
Alunos aluno6 = new Alunos("FFFF", "76587645365", "05/09/2004", 160, 70, 90);
Alunos aluno7 = new Alunos("GGGG", "87654326546", "19/12/1998", 0, 60, 90);

Console.WriteLine(aluno1.AprovaReprova());

public class Alunos
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string DataDeNascimento { get; set; }
    public int Faltas { get ; set; }
    public int Nota1 { get; set; }
    public int Nota2 { get; set; }

    public Alunos(string nome, string cPF, string dataDeNascimento, int faltas, int nota1, int nota2)
    {
        Nome = nome;
        CPF = cPF;
        DataDeNascimento = dataDeNascimento;
        Faltas = faltas;
        Nota1 = nota1;
        Nota2 = nota2;
    }

    public void Faltou()
    {
        this.Faltas = this.Faltas + Faltas;
    }

    public int GetFaltas()
    {
        return this.Faltas;
    }

    public void SetNota(int nota1, int nota2)
    {
        this.Nota1 = nota1;
        this.Nota2 = nota2;
    }

    public string AprovaReprova()
    {
        float media = (this.Nota1 + this.Nota2) / 2;
        if (media >= 70)
            return ("Aprovado");
        else
            return ("Reprovado");
    }
}

