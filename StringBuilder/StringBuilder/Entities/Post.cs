using System;
using System.Text;
using System.Collections.Generic;

namespace StringBuilder.Entities
{
    internal class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo{ get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> comentarios { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            comentarios.Add(comentario);
        }
        public void RemoveComentario(Comentario comentario)
        {
            comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes -  ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("Comentários: ");
            foreach (Comentario c in comentarios)
            {
                sb.AppendLine("- " + c.Texto);
            }
            return sb.ToString();
       
            
        }
    }
}
