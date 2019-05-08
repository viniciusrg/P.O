using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class pessoa
	{
		private string nome;
		private float peso;
		private tdata datanasc;

		public string Nome { get => nome; set => nome = value; }
		public float Peso { get => peso; set => peso = value; }

		public pessoa ()
		{
			datanasc = new tdata();
		}

		public string setdatanasc(int d,int m, int a)
		{
			string aux = "";
			if (datanasc.gravar(d, m, a))
				aux = "data valida";
			else
				aux = "data invalida";

			return aux;
		}

		public string getdatanasc ()
		{
			
			return datanasc.mostra();
		}

		public string mostrapessoa()
		{
			string x = " ";

			return x= "Nome: "+nome+ ", Peso: "+peso+", ";
		}
	}
}
