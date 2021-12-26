class Matematica
{
    public int Numero1 { get; set; }
    public int Numero2 { get; set; }
    public int Resultado { get; set; }

    public Matematica()
    {
    }
    
    public Matematica(int numero1, int numero2, int resultado)
    {
        Numero1 = numero1;
        Numero2 = numero2;
        Resultado = resultado;
    }

    public int Suma(){
        Resultado = Numero1 + Numero2;
        return Resultado;
    }

    public int Resta(){
        Resultado = Numero1 - Numero2;
        return Resultado;
    }

    public int Multiplicacion(){
        Resultado = Numero1 * Numero2;
        return Resultado;
    }

    public int Division(){
        Resultado = Numero1 / Numero2;
        return Resultado;
    }
}