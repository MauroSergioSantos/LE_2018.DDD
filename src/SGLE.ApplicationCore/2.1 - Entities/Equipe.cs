using System;
using System.Collections.Generic;
using System.Text;

namespace SGLE.ApplicationCore._2._1___Entities
{
    public class Equipe
    {
        public Equipe()
        {

        }

        public int EquipeId { get; set; }
        public string NomeEquipe { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Campeonato Campeonato { get; set; }
        public ICollection<Atleta> Atletas { get; set; }
    }
}
