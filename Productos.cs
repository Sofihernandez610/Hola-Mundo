using System.Collections.Generic;

namespace EjercicioRepos
{
    public class Productos
    {
        public string Nombre { get; set;}
        public int Precio { get; set;}

        public List<Review> Review{get; set;} = new List<Review>();

        public Productos(string nombre, int precio)//List<Review> review)
        {
            this.Nombre= nombre;
            this.Precio=precio;
            //this.Review=review;

        }
        public override string ToString()
        {
            return ($"El nombre es  {this.Nombre} y su precio es {this.Precio}");
        }

        public void AgregarReview(Review review)
        {
            Review.Add(review);
        }
    }
}