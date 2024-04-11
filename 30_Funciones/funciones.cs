

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
