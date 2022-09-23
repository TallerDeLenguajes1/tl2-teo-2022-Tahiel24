using System;

public abstract class CuentasBancarias
{
    private int DineroDisponible;
    private int TipoCajero;
    private int montoExtraidoCajero;
    public int DineroDisponible1 { get => DineroDisponible; set => DineroDisponible = value; }
    public int TipoCajero1 { get => TipoCajero; set => TipoCajero = value; }
    public int MontoExtraidoCajero { get => montoExtraidoCajero; set => montoExtraidoCajero = value; }

    public abstract void Insercion(int monto);
    public abstract int Extraccion(int monto, int tipo);

    //public abstract int ConsultarTipoCajero();
    //public abstract int ConsultarDineroDisponible();
    public int ConsultarTipoCajero()
    {
        return TipoCajero1;
    }

    public int ConsultarDineroDisponible()
    {
        return DineroDisponible1;
    }
}

class CuentaPesos : CuentasBancarias
{
    public CuentaPesos(int monto, int tipo)
    {
        DineroDisponible1 = monto;
        TipoCajero1 = tipo;
    }

    public override void Insercion(int monto)
    {
        DineroDisponible1 = monto;
    }

    public override int Extraccion(int Monto, int tipo)
    {
        if (tipo == 1)
        {
            DineroDisponible1 -= Monto;
            return DineroDisponible1 -= Monto;
        }
        else
        {
            if (Monto <= 20000)
            {
                DineroDisponible1 -= Monto;
                return DineroDisponible1 -= Monto;
            }
            else
            {
                Console.WriteLine("Se ha excedido del monto diario disponible para extraccion");
                return 0;
            }
        }
    }

}

class CuentaDolares : CuentasBancarias
{
    public CuentaDolares(int monto, int tipo)
    {
        DineroDisponible1 = monto;
        TipoCajero1 = tipo;
    }

    public override void Insercion(int monto)
    {
        DineroDisponible1 = monto;
    }

    public override int Extraccion(int Monto, int tipo)
    {
        if (tipo == 1)
        {
            DineroDisponible1 -= Monto;
            return DineroDisponible1 -= Monto;
        }
        else
        {
            if (Monto <= 200)
            {
                DineroDisponible1 -= Monto;
                return DineroDisponible1 -= Monto;
            }
            else
            {
                Console.WriteLine("Se ha excedido del monto diario disponible para extraccion");
                return 0;
            }

        }
    }

    class cuentaAhorroPesos : CuentasBancarias
    {
        public override void Insercion(int monto)
        {
            DineroDisponible1 = monto;
        }
        public cuentaAhorroPesos(int monto, int tipo)
        {
            DineroDisponible1 = monto;
            TipoCajero1 = tipo;
        }
        public override int Extraccion(int Monto, int tipo)
        {
            if (tipo == 1)
            {
                DineroDisponible1 -= Monto;
                return DineroDisponible1 -= Monto;
            }
            else
            {
                if (Monto <= 10000)
                {
                    DineroDisponible1 -= Monto;
                    return DineroDisponible1 -= Monto;
                }
                else
                {
                    Console.WriteLine("Se ha excedido del monto diario disponible para extraccion");
                    return 0;
                }
            }
        }
    }

}