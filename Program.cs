namespace EjercicioRepos
{
    class MainApp
    {
        public static void Main ()
        {
            Productos producto1= new Productos ("Harry Potter", 1200 );
            Productos producto2 = new Productos("BlancaNieves", 350);

            Review review1 = new Review(5,"Muy bueno");
            Review review2 = new Review(3,"Muy infantil");

            producto1.AgregarReview(review1);
            producto2.AgregarReview(review2);

            Console.WriteLine (producto1);


            
            
        }
    }
}
