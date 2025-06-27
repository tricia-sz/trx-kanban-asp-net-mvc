namespace TrxKanban.Models
{
    public class AtividadeModel
    {
        public int Id { get; set; }

        public int Matricula { get; set; }
        public string Titulo { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public int StatusId { get; set; }

        public StatusModel Status { get; set; }
    }
}
