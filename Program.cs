using System;


namespace actividad_en_clase
{
    class Program
    {
        class Banco
        {
            private Cliente cliente1, cliente2, cliente3;

            public Banco()
            {
                cliente1 = new Cliente("Miguel Moreta");
                cliente2 = new Cliente("Cesar Rojas");
                cliente3 = new Cliente("Alvaro Valenzuela");
            }

            public void Operar()
            {
                cliente1.Depositar(2800);
                cliente2.Depositar(2500);
                cliente3.Depositar(3000);
                cliente1.Extraer(1050);//sera el dinero a extraer del cliente 1 en este caso miguel moreta
            }

            public void DepositosTotales()
            {
                int t = cliente1.RetornarMonto() +
                        cliente2.RetornarMonto() +
                        cliente3.RetornarMonto();

                        Console.WriteLine();
                        Console.WriteLine("El dinero Total en el banco:" + t);
                        Console.WriteLine();
                        cliente1.Imprimir();
                        cliente2.Imprimir();
                        cliente3.Imprimir();
            }

            static void Main(string[] args)
            {
                Banco banco1 = new Banco();
                banco1.Operar();
                banco1.DepositosTotales();
                Console.ReadKey();
            }
            class Cliente
            {
                private string nombre;
                private int monto;

                public Cliente(string nom)
                {
                    nombre = nom;
                    monto = 0;
                }

                public void Depositar(int D)
                {
                    monto = monto + D;
                }

                public void Extraer(int M)
                {
                    monto = monto - M;
                }

                public int RetornarMonto()
                {
                    return monto;
                }

                public void Imprimir()
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine(nombre + " tiene en la cuenta depositado una suma de: " + "$" + monto);
                    Console.WriteLine("------------------------------------------------------------");
                }

            }
        }
    }
}

