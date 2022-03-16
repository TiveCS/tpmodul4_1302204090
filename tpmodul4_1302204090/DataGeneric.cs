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

		public DataGeneric(T data)
		{
			this.data = data;
		}

		public void PrintInfo()
		{
			Console.WriteLine("Data yang tersimpan adalah: " + this.data);
		}


	}
}
