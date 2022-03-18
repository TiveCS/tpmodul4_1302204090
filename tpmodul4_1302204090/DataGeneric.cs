using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204090
{
	internal class DataGeneric<T>
	{
	
		private T data;

		// Deklarasi konstruktor
		public DataGeneric(T data)
		{
			this.data = data;
		}
		
		// Print data yang tersimpan dengan field "data" dari Class
		public void PrintInfo()
		{
			Console.WriteLine("Data yang tersimpan adalah: " + this.data);
		}


	}
}
