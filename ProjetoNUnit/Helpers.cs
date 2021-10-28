using NUnit.Framework;
public class Helpers
{
    public static bool MaiorDeIdade(int idade)
    {
            if (idade >= 18) return true;
            else return false;
    }
    public static bool MenorDeIdade(int idade)
    {
        if (idade < 18) return true;
            else return false;
    }
    public static bool ValidaNome(string nome)
    {
        if (nome =="Mara") return true;
            else return false;
    }

}