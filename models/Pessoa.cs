namespace bancoSMN.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public Pessoa(string nome, DateOnly dataNascimento, char sexo)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Idade = CalcularIdade();
            Sexo = sexo;
        }

        public int CalcularIdade()
        {
            DateOnly aniversarioTeste = new DateOnly(1994, 10, 16);
            DateOnly dataHoje = DateOnly.FromDateTime(DateTime.Now);
            int idade = 0;
            return idade;
        }
    }
}