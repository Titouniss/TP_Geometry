using System;

public class forme<T>
{
    private T valeur;
    public forme (T laValeur)
    {
        this.valeur = laValeur;
    }
    public T GetValeur()
    {
        return this.valeur;
    }

    public void setValeur(T laValeur)
    {
        this.valeur = laValeur;
    }
}
