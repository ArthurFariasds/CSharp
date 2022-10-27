using System;

namespace StringBuilder.Entities
{
    internal class Comentario
    {
        public  string Texto { get; set; }

        public Comentario()
        {
        }
        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}
