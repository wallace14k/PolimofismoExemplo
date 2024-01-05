// See https://aka.ms/new-console-template for more information


var numero = new Numero();

numero.num = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(numero.num + "-" + numero.tipo);


public class ValidarNumero
{
    public virtual string Tipo(int numero)
    {
        if (numero % 2 == 0)
        {
            return "Par";
        }
        else
        {
            return "Impar";
        }
    }
}


public class Numero : ValidarNumero

{
    public int num { get; set; }
    public string tipo { get => Tipo(num); }
    public override string Tipo(int numero)
    {
        return base.Tipo(numero);
    }
}




