using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class paciente:pessoa
	{
		
		private string matricula;

		public string Matricula { get => matricula; set => matricula = value; }
		

		public paciente()
		{

		}

		public string mostrapaciente()
		{
			string x = "";
			return x=mostrapessoa()+" Matricula: "+matricula+" ,"+getdatanasc();
		}
	}
}
