namespace Clases;

public abstract class CuentaBancaria
{
    public string NumeroCuenta { get; }
    public string Titular { get; set; }
    public decimal Saldo { get; protected set; }

    public CuentaBancaria(string numeroCuenta, string titular, decimal saldoInicial)
    {
        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public bool Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            return false;
        }
        Saldo += monto;
        return true;
    }

    public abstract bool Retirar(decimal monto);
}
