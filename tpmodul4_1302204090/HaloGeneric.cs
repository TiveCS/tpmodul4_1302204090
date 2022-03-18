using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204090
{
	internal class HaloGeneric<T>
	{
		// Print "Halo User" dengan input dari parameter 
		public void SapaUser(T input)
		{
			Console.WriteLine("Halo user " + input);
		}

	}
}
