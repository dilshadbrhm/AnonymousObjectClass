namespace ClassConsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("DD","dd","pb644",64);
            //student.PrintInfo();
            //student.CheckGraduation();
            //student.GetDiplomDegree();

            Product product = new Product("Iphone","15 pro",1000,100,10);
            product.PrintInfo();
            product.Sale(5);
            product.Refill(5);
            product.PrintInfo();
            
        }
    }
}
