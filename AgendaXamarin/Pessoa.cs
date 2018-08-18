using System;
using SQLite;
namespace AgendaXamarin
{
    public class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public uint Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
