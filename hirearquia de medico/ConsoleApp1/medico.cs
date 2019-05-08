using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class medico:pessoa
	{
		private List<paciente> lp;
		private string especialidade;

		public string Especialidade { get => especialidade; set => especialidade = value; }
		public List<paciente> Lp { get => lp; }

		public medico()
		{
			lp = new List<paciente>();

		}

		public void registrarp (paciente p)
		{
			lp.Add(p);
		}

		public string mostramed ()
		{
			string x = "";
			return x= mostrapessoa()+" Especialidade: "+especialidade;
		}

		public string mostralista ()
		{
			string x = "";
			foreach (paciente item in lp)
			{
				x +="Nome: "+ item.Nome + " , Peso: " + item.Peso + " , Matricula: " + item.Matricula + " ," +getdatanasc();
			}
			return x;
		}

	}
}
