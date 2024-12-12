namespace NgenoFinalExam
{
    public class Rect
    {
        public double Height { get; set; }
        public double Length { get; set; }

        public static double ComputeArea1(Rect rec)
        {
            return rec.Height * rec.Length;
        }

        public double ComputeArea2()
        {
            return Height * Length;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // 1) explain the following line:
            // This line creates a new instance of the Rect class and initializes its Height and Length properties using object initializer syntax.
            var r = new Rect { Height = 2, Length = 3 };

            // 2) Invoke ComputeArea1 to compute the area of r and display the result
            double area1 = Rect.ComputeArea1(r);
            Console.WriteLine("Area computed using ComputeArea1: " + area1);

            // 3) Change the rectangle's height and length to 4 and 6, respectively
            r.Height = 4;
            r.Length = 6;

            // 4) Invoke ComputeArea2 to compute the area of r, and display the result
            double area2 = r.ComputeArea2();
            Console.WriteLine("Area computed using ComputeArea2: " + area2);
        }
    }
}
