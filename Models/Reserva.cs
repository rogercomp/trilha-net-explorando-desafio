namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;            
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (this.Suite.Capacidade > hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hospede não pode exceder a capacidade da suite!");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)            
            if(this.Hospedes == null)
            {
                this.Hospedes = new List<Pessoa>();                
            }       

            return this.Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria            
            decimal valor = this.DiasReservados * this.Suite.ValorDiaria;            
            decimal desconto = 0.10M;

           // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%            
            if (this.DiasReservados == 10)
            {

                valor = valor - (valor * desconto);
            }

            return valor;
        }
    }
}