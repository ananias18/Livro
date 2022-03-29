

public class Pessoa
{
    private string name;
    private int idade;
    private string sexo;

    public void fazerAniver()
    {
        this.idade++;
    }

    public Pessoa(string name, int idade, string sexo)
    {
        this.name = name;
        this.idade = idade;
        this.sexo = sexo;
    }

    public string getName()
    {
        return this.name;
    }
    public int getIdade()
    {
        return this.idade;
    }
    public string getSexo()
    {
        return this.sexo;
    }
    public void setName(string n)
    {
        this.name = n;
    }
    public void setIdade(int id)
    {
        this.idade = id;    
    }
    public void setSexo()
    {

    }
}