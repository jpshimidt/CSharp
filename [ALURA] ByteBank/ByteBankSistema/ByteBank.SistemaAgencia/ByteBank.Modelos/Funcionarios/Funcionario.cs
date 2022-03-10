namespace ByteBank.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        protected internal virtual double GetBonificacao()
        {
            return 0;
        }

        public abstract void AumentarSalario();
    }
}
