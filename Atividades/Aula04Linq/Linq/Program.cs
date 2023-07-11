using Linq.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void TestaLinq()
        {
            // Lista de Generos
            List<Genero> generos = new List<Genero>()
            {
                new Genero{Id = 1,nome = "Samba"},
                new Genero {Id = 2,nome ="Rap"},
                new Genero{Id = 3,nome = "Trap"},
                new Genero{Id=4,nome ="Rock"}

            };
            //Query de consulta LInq
            var query = from g in generos
                        where g.nome.Contains("Rap")
                        select g;

            var query2 = from g in generos
                         where g.Id == 2
                         select g;

            var query3 = from g in generos
                         where g.nome.Length > 2
                         select g;

            //Listando e apresentando dados
            foreach (var genero in query)
            {
                Console.WriteLine("{0}\t{1}", genero.Id, genero.nome);
            }

            // Lista de musicas
            var musicas = new List<Musica>
            {
                    new Musica { id = 1, Nome = "Lose yourself", GeneroId = 2, AutorId = 1,AlbumID =1},
                    new Musica { id = 2, Nome = "Not afraid", GeneroId = 2,AutorId =1,AlbumID =2},
                    new Musica { id = 3, Nome = "777-666", GeneroId = 3},
                    new Musica { id = 4, Nome = "Nothing Else Mathers", GeneroId = 4}
            };

            //Query de consulta LINQ
            var musicaQuery = from m in musicas
                              select m;
            //Listando e apresentando dados
            foreach (var musica in musicas)
            {
                Console.WriteLine($"ID {musica.id} Nome: {musica.Nome} GeneroID:{musica.GeneroId}");
            }

            // Juntando as duas listas como tabelas para consulta 

            var musicQuery = from m in musicas
                             join g in generos on m.GeneroId equals g.Id
                             select new { m, g };

            foreach (var musica in musicQuery)
            {
                Console.WriteLine("{0}\t{1}\t{2}", musica.m.id, musica.m.Nome, musica.g.nome);
            }

            // Lista de Autores
            List<Autor> autores = new List<Autor>()
            {
                new Autor{Id =1,Nome="Eminem" }

            };

            //Lista de Album

            List<Album> albuns = new List<Album>() {

            new Album{id=1,nome="The Eminem Show",AutorId = 1},
            new Album{id=2,nome="Recovery",AutorId = 1},

            };

            //Lista de Colecão

            List<Colecao> colecao = new List<Colecao>() {

            new Colecao{id=1,nome="Janderson",AlbumId=1},

            };

            //Join com três 
            var autorquery = from a in autores
                             join m in musicas on a.Id equals m.AutorId
                             join ab in albuns on a.Id equals ab.AutorId
                             //     join gm in generos on m.GeneroId equals gm.Id
                             select new { a, m, ab }; // lista de object do tipo anônimo

            var autorquery2 = from pro in autorquery
                              select new { pro.a };

            foreach (var autor in autorquery)
            {
                Console.WriteLine($"Autor {autor.a.Nome} Musicas {autor.m.Nome} Albuns {autor.ab.nome}");
            }


            //foreach (var autor in autorquery)
            //{

            //    Console.WriteLine($"Musica: {autor.m.Nome} , Genero: {autor.g.nome}, Autor: {autor.a.Nome}");
            //}


        }
    }
}
