using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UnitTestExercises
{
	public class Run
	{

     public void jun()
     {  
			Main M = new Main();	
		
		while (true)
	    {
                Console.WriteLine("Insert X...");
				int x = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Insert Y...");
				int y = Convert.ToInt16(Console.ReadLine());
				M.Jam(x, y);
		}
		
	 }

	}
}
