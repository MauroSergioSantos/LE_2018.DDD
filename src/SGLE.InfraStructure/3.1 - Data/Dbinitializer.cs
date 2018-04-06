using SGLE.ApplicationCore._2._1___Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGLE.InfraStructure._3._1___Data
{
    public static class DbInitializer
    {
        public static void Initialize(LigaContext Context)
        {
            if (Context.Arbitros.Any())
            {
                return;
            }

            var arbitros = new Arbitro[]
            {
                new Arbitro
                {
                    NomeArbitro = "Antonio Manoel da Silva",
                    CPF = "79804244330",
                    RG = "035030",
                    Altura = 1.80M,
                    Peso = 79,
                    DataNascimento = new
                    DateTime(1974,05,04),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Cuiabá",
                    Endereco = "Rua das Flores nr 20",
                    Tipo = TipoArbitro.Arbitro
                   
                },
                new Arbitro
                {

                    NomeArbitro = "José Carlos Aguiar",
                    CPF = "81124926119",
                    RG = "047035",
                    Altura = 1.77M,
                    Peso = 76,
                    DataNascimento = new
                    DateTime(1971,17,12),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Poconé",
                    Endereco = "Rua das Dalias nr 35",
                    Tipo = TipoArbitro.Arbitro
                
                },
                new Arbitro
                {
                    NomeArbitro = "Pedro Paulo dos santos",
                    CPF = "63843314896",
                    RG = "09517215",
                    Altura = 1.82M,
                    Peso = 69,
                    DataNascimento = new
                    DateTime(1968,17,03),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Cáceres",
                    Endereco = "Rua das Orquideas nr 40",
                    Tipo = TipoArbitro.ArbitroAssistente
                    
                }

            };

            Context.AddRange(arbitros);

            var assistentes = new Assistente[]
            {
 
                new Assistente
                {
                    NomeAssistente = "Franklin Martins",
                    CPF = "63843314896",
                    RG = "09517215",
                    Altura = 1.82M,
                    Peso = 69,
                    DataNascimento = new
                    DateTime(1968,17,03),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Cáceres",
                    Endereco = "Rua das Orquideas nr 40",
                    Tipo = TipoAssistente.Assistente1,
                    Arbitro = arbitros[0]
                },

                new Assistente
                {
                    NomeAssistente = "Pablo Fayouk",
                    CPF = "62815714523",
                    RG = "403289440",
                    Altura = 1.72M,
                    Peso = 63,
                    DataNascimento = new
                    DateTime(1968,17,03),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Cáceres",
                    Endereco = "Rua 45 Qda 32 nr 40",
                    Tipo = TipoAssistente.Assistente2,
                    Arbitro = arbitros[1]
                },

                new Assistente
                {
                    NomeAssistente = "Francisco Pereira de Carvalho",
                    CPF = "64041737516",
                    RG = "429434121",
                    Altura = 1.75M,
                    Peso = 68,
                    DataNascimento = new
                    DateTime(1969,27,08),
                    Nacionalidade = "Brasileira",
                    Naturalidade = "Rondonópolis",
                    Endereco = "Av José Torquato nr 142",
                    Tipo = TipoAssistente.Assistente2,
                    Arbitro = arbitros[2]
                }
            };

            Context.AddRange(assistentes);

            var atletas = new Atleta[]
            {
                new Atleta
                {
                    NomedoAtleta = "Mauro Sergio dos Santos",
                    CPF = "70307542475",
                    RG = "429434121",
                    Altura = 1.81M,
                    Peso = 67,
                    DatadeNascimento = new
                    DateTime(1971,22,05),
                    Naturalidade = "Pontes e Lacerda",
                    Nacionalidade = "Brasileira",
                    Endereco = "Rua Padre Anchieta nr 420",
                    Categoria = EquipeCategoria.Titular,
                    Posicao = PosicaoCampo.Atacante,
                    

                },
                 
                new Atleta
                {
                    NomedoAtleta = "Lucas Guilherme Pereira",
                    CPF = "56586257697",
                    RG = "418757896",
                    Altura = 1.81M,
                    Peso = 67,
                    DatadeNascimento = new
                    DateTime(1971,22,05),
                    Naturalidade = "Pontes e Lacerda",
                    Nacionalidade = "Brasileira",
                    Endereco = "Rua Padre Anchieta nr 420",
                    Categoria = EquipeCategoria.Titular,
                    Posicao = PosicaoCampo.Atacante
                },

                new Atleta
                {
                    NomedoAtleta = "Vinicius Pacheco",
                    CPF = "03877440290",
                    RG = "429434121",
                    Altura = 1.71M,
                    Peso = 65,
                    DatadeNascimento = new
                    DateTime(1969,27,02),
                    Naturalidade = "Campo Grande",
                    Nacionalidade = "Brasileira",
                    Endereco = "Rua Padre Bras nr 42",
                    Categoria = EquipeCategoria.Titular,
                    Posicao = PosicaoCampo.MeiaArmador
                },

                new Atleta
                {
                    NomedoAtleta = "Pedro Paulo Rangel",
                    CPF = "46219206185",
                    RG = "911225341",
                    Altura = 1.95M,
                    Peso = 78,
                    DatadeNascimento = new
                    DateTime(1971,22,05),
                    Naturalidade = "Porto Alegre",
                    Nacionalidade = "Brasileira",
                    Endereco = "Rua Tamoios nr 487",
                    Categoria = EquipeCategoria.Titular,
                    Posicao = PosicaoCampo.Goleiro
                }
            };

            Context.AddRange(atletas);

            var campeonatos = new Campeonato[]
            {
                new Campeonato
                {
                    NomedoCampeonato = "Liga Esportiva Amadora CPA",
                    DataInicio = new
                    DateTime(2018,25,02),
                    DataFim = new
                    DateTime(2018,22,12)
                    
                }
            };

            Context.AddRange(campeonatos);

            var equipes = new Equipe[]
            {
                new Equipe
                {
                    NomeEquipe = "AAPA - Associação Amigos Parque Atalaia",
                    Email = "aapa2018@hotmail.com.br",
                    Endereco = "Rua das Flores nr 700",
                    DataCadastro = new
                    DateTime(2018,21,02),
                    Campeonato = campeonatos[0],
                   
                    
                }
            };

            Context.AddRange(equipes);

            Context.SaveChanges();
        }
    }
}
