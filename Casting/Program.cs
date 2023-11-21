public class Program 
{
  public static void Main()
  {
    long n1 = 5645646515615616;

    int n2 =(int)n1; //type cast operator

    short n3 = (short)n1;

    string n4 = Convert.ToString(n3); //type cast operator

    int n5 = Convert.ToInt32(n4); //type cast operator

    Console.WriteLine(n5);
  }
}