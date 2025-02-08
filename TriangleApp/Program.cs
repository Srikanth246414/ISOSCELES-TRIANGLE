                //NAME:CILUKURI SRIKANTH(mutant version)

namespace TriangleApp{
public class Triangle
{
    public static bool IsIsosceles(int a, int b, int c)
    {
        //checking equilateral triangle instead of isosceles for mutation
        return a == b && b == c ;
    }
    public static void Main(string[] args){
        Console.WriteLine("TestExecuted by Chilukuri Srikanth");
        Console.WriteLine(IsIsosceles(5,4,5));
    }
}
}

