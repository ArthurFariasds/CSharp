using System;
using StringBuilder.Entities;

namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comentario coment1 = new Comentario("Tenha uma boa viagem!");
            Comentario coment2 = new Comentario("Que sensacional!");

            Post post = new Post(
                DateTime.Parse("26/10/2022 10:17:33"),
                "Viajando para o Egito",
                "Estou indo visitar esse país maravilhoso",
                12);

            post.AddComentario(coment1);
            post.AddComentario(coment2);

            Console.WriteLine(post);

            Console.ReadKey();

        }

    }
}
