using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204090
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Demo DataGeneric
			DataGeneric<String> data = new DataGeneric<string>("1302204090");
			data.PrintInfo();

			// Demo HaloGeneric
			HaloGeneric<String> halo = new HaloGeneric<string>();
			halo.SapaUser("Udin");
		}
	}
}
