using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a função f(x) = sin(x)/x
        Func<double, double> f = x => Math.Sin(x) / x;

        // Define o valor de x para o qual o limite deve ser calculado
        double x = 9.6;

        // Define a precisão desejada
        double epsilon = 0.0001;

        // Calcula o limite usando o Teorema de L'Hôpital
        double limite = CalcularLimite(f, x, epsilon);

        Console.WriteLine("O limite da função é: {0}", limite);
        Console.ReadLine();
    }

    static double CalcularLimite(Func<double, double> f, double x, double epsilon)
    {
        double limite = double.NaN;

        // Verifica se a função é indeterminada em x = a (0/0 ou inf/infinity)
        if (double.IsNaN(f(x) / 0.0) || double.IsInfinity(f(x) / 0.0))
        {
            // Se a função é indeterminada em x = a, aplica o Teorema de L'Hôpital
            double f1 = Derivada(f, x);
            double g1 = Derivada(x => x, x);

            while (Math.Abs(f1 / g1) > epsilon)
            {
                f = Derivada(f);
                f1 = Derivada(f, x);
                g1 = Derivada(x => x, x);
            }

            limite = f(x) / g1;
        }
        else
        {
            // Se a função não é indeterminada em x = a, calcula o limite diretamente
            limite = f(x);
        }

        return limite;
    }

    static Func<double, double> Derivada(Func<double, double> f)
    {
        double h = 0.0001;
        return x => (f(x + h) - f(x)) / h;
    }

    static double Derivada(Func<double, double> f, double x)
    {
        double h = 0.0001;
        return (f(x + h) - f(x)) / h;
    }
}
