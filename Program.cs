using Aula9.Aniversario;


public class program
{
    public static void Main(string[] args)
    {
        Pessoa[] p = new Pessoa[2];
        Livro[] l = new Livro[3];

        p[0] = new Pessoa("clep", 24, "Masculino");
        p[1] = new Pessoa("Maria", 25, "Feminino");

        l[0] = new Livro("O senhor dos Aneis", "J.R.R. Tolkien", 1234, p[0]);
        l[1] = new Livro("O Hobbit", "J.R.R. Tolkien", 1234, p[0]);
        l[2] = new Livro("Aprendendo C#", "Pedro Paulo", 500, p[0]);

        
        l[0].abrir();
        l[0].folhear(100);
        l[0].avancarPag();
        Console.WriteLine(l[0].detalhes());

        Console.WriteLine(l[1].detalhes());

    }
}
