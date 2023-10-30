using System;

namespace PMPHF007
{
  class Program
  {
    static double[] values;
    static void Main()
    {
      ReadIn();
      Check();
    }

    static void ReadIn()
    {
      string line = Console.ReadLine();
      values = new double[(line.Length) / 2];
      int j = 0;
      for (int i = 0; i < line.Length; i++)
      {
        string tmp = Convert.ToString(line[i]) + "." + Convert.ToString(line[++i]);
        values[j] = double.Parse(tmp);
        j++;
      }
    }

    static void Check()
    {
      for (int i = 0; i < values.Length; i++)
      {
        if (values[i] >= 0 && values[i] <= 0.8)
          Console.Write(0);
        else if (values[i] >= 2.7 && values[i] <= 5)
          Console.Write(1);
        else
          Console.Write("E");
      }
      Console.WriteLine();
    }
  }
}
