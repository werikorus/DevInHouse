namespace POO_ASPNET.Entities
{
    public class Carro : Veiculo
    {
        public Carro(string nome) : base(nome) { }

        public override void Acelerar(int velocidade)
        {
            base.Acelerar(2);
        }
    }
}
