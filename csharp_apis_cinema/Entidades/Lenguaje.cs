﻿namespace csharp_apis_cinema.Entidades
{
    public class Lenguaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public HashSet<Sistema> Sistemas { get; set; } = new HashSet<Sistema>();
    }
}
