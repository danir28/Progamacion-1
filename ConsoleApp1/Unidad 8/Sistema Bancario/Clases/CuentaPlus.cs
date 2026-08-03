namespace Clases;

public class CuentaPlus : CuentaBancaria
{
    public const decimal PorcentajeComision = 0.025m;

    public CuentaPlus(string numeroCuenta, string titular, decimal saldoInicial)
        : base(numeroCuenta, titular, saldoInicial)
    {
    }

    public override bool Retirar(decimal monto)
    {
        if (monto <= 0)
        {
            return false;
        }
        decimal comision = monto * PorcentajeComision;
        decimal totalADescontar = monto + comision;
        if (totalADescontar > Saldo)
        {
            return false;
        }
        Saldo -= totalADescontar;
        return true;
    }
}
