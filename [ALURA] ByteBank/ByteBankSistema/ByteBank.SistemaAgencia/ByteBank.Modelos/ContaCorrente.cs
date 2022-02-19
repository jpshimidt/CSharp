namespace ByteBank.Modelos
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        private double _saldo = 100;

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
