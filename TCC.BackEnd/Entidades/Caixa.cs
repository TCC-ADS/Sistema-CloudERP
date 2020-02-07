namespace Domain.Entidades
{
    public class Caixa : Entidade
    {
        public double Valor { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
