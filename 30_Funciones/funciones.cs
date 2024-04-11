

int Sumar(int a, int b)
{
    return a + b;
}

int Restar(int a, int b)
{
    return a - b;
}

int Multiplicar(int a, int b)
{
    return a * b;
}

double Dividir(double a, double b)
{
    if (b != 0)
        return a / b;
    else
        throw new DivideByZeroException("No se puede dividir por cero.");
}

int Maximo(int a, int b)
{
    return Math.Max(a, b);
}

int Minimo(int a, int b)
{
    return Math.Min(a, b);
}

int Factorial(int n)
{
    if (n == 0)
        return 1;
    else
        return n * Factorial(n - 1);
}

bool EsPar(int num)
{
    return num % 2 == 0;
}

bool EsImpar(int num)
{
    return num % 2 != 0;
}

double AreaCirculo(double radio)
{
    return Math.PI * Math.Pow(radio, 2);
}

int ContarCaracteres(string cadena)
{
    return cadena.Length;
}
