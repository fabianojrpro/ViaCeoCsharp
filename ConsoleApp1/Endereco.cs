
namespace ConsoleApp1
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }

        public Endereco(string logradouro, string bairro, string localidade, string uf)
        {
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.localidade = localidade;
            this.uf = uf;

            validaCampos();
        }

        public void validaCampos()
        {
            if (this.logradouro == "")
            {
                this.logradouro = "Não encontrado";
            }
            if (this.bairro == "")
            {
                this.bairro = "Não encontrado";
            }
            if (this.localidade == "")
            {
                this.localidade = "Não encontrado";
            }
            if (this.uf == "")
            {
                this.uf = "Não encontrado";
            }
        }

        public override string ToString()
        {
            return $"Logradouro: {logradouro}\nBairro: {bairro}\nLocalidade: {localidade}\nUF: {uf}";
        }

    }
}
