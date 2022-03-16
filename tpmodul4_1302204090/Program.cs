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
			DataGeneric<String> data = new DataGeneric<string>("1302204090");
			data.PrintInfo();
			HaloGeneric<String> halo = new HaloGeneric<string>();
			halo.SapaUser("Udin");
		}
	}
}
