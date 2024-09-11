using System;

public class Animacao
{
	public void RunAnimacao()
	{
		List<string> peixes = new List<string>();
        Console.Clear();



        peixes.Add(@"
      ><(((º>
");

        peixes.Add(@"
            ><(((º>
");
        peixes.Add(@"
                ><(((º>
");
        peixes.Add(@"
                 ><(((º>
");
        peixes.Add(@"
                    ><(((º>
");
        peixes.Add(@"
                     ><(((º>
");
        //voltando

        peixes.Add(@"
                    <º)))><
");

        peixes.Add(@"
                 <º)))><
");
        peixes.Add(@"
             <º)))><
");

        peixes.Add(@"
          <º)))><
");

        peixes.Add(@"
      <º)))><
");




        foreach (var peix in peixes) {
            Console.WriteLine(peix);
            Thread.Sleep(500);
            Console.Clear();
        }
        foreach (var peix in peixes)
        {
            Console.WriteLine(peix);
            Thread.Sleep(500);
            Console.Clear();
        }

    }
}
