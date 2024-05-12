namespace Calculadora;

internal class OperaçõesNumericas
{
    public static double Soma(double numero1, double numero2)
    {
        return numero1 + numero2;
    }
    public static double Subtração(double numero1, double numero2)
    {
        return numero1 - numero2;
    }
    public static double Multiplicação(double numero1, double numero2)
    {
        return numero1 * numero2;
    }
    public static dynamic Divisão(double numero1, double numero2)
    {
        if (numero2 == 0)
        {
            return "Não é possivel dividir por 0";
        } else
        {
            return numero1 / numero2;
        }
    }

    public static double Media(double numero1, double numero2)
    {
        return (numero1 + numero2) / 2;
    }
}
