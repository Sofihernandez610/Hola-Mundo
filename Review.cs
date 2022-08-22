namespace EjercicioRepos
{
    public class Review
    {
        public int Calificacion { get; set;}
        public string Comentario { get; set;}


        public Review(int calificacion, string comentario)
        {
            this.Calificacion= calificacion;
            this.Comentario=comentario;
            

        }
        public override string ToString()
        {
            return ($"La calificación es de {this.Calificacion} y su comentario es {this.Comentario}");
        }
    
    }
}