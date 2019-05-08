using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class funcionario:pessoa
	{
		private string cargo;
		private float sal;

		public string Cargo { get => cargo; set => cargo = value; }
		public float Sal { get => sal; set => sal = value; }

		public funcionario()
		{

		}
		public string mostraf()
		{
			string x = "";
			return x=mostrapessoa()+"Cargo: "+cargo+", Salario: "+sal+" ," + getdatanasc();
		}
	}
}
