namespace KanbanDD8.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string SenhaHash { get; set; }
     
    }

    public class Tarefa
    {
        public long Id { get; set; }
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public required string Status { get; set; }
        public DateTime Data { get; set; }
        public long UserId { get; set; }       
    }
}