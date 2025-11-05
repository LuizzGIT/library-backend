namespace Biblioteca.Domain
{
    public  class Emprestimo
    {
        public enum StatusEmprestimo
        {
            Emprestado,
            Atrasado,
            Devolvido

        }
        public int Id { get; set; }

        public StatusEmprestimo Status { get; set; }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }

        public DateTime? DataDevolucaoReal {  get; set; } // ? pois pode ser nulo se não for devolvido

        // FKs

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }  
}
