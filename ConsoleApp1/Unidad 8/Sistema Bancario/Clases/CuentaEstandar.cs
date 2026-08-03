namespace Clases;

public class CuentaEstandar : CuentaBancaria
{
    public const decimal LimiteExtraccion = 50000;
    public const decimal PorcentajeComision = 0.05m;

    public CuentaEstandar(string numeroCuenta, string titular, decimal saldoInicial)
        : base(numeroCuenta, titular, saldoInicial)
    {
    }

    public override bool Retirar(decimal monto)
    {
        if (monto <= 0 || monto > LimiteExtraccion)
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
