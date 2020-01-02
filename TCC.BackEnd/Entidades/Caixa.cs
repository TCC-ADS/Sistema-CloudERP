namespace Domain.Entidades
{
    public class Caixa : Entidade
    {
        public double valor { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
