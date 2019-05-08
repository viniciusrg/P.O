using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<funcionario> lf = new List<funcionario>();
			List<paciente> lp = new List<paciente>();
			List<medico> lm = new List<medico>();
			funcionario f = null;
			paciente p = null;
			medico m = null;
			int op,vd,va,vm,op2;
			string nomemed, mat,nomep;

			do
			{
				Console.Clear();
				Console.WriteLine("1-Funcionario");
				Console.WriteLine("2-Paciente");
				Console.WriteLine("3-Medico");
				Console.WriteLine("4-Mostrar todos");
				Console.WriteLine("5-Sair");
				Console.Write("Opçao: ");
				op = int.Parse(Console.ReadLine());
				switch (op)
				{
					case 1:
						Console.WriteLine("1-Cadastrar");
						Console.WriteLine("2-Mostrar");
						op2 = int.Parse(Console.ReadLine());
						switch (op2)
						{
							case 1:
								f = new funcionario();
								Console.WriteLine("Nome:");
								f.Nome = Console.ReadLine();
								Console.WriteLine("Peso:");
								f.Peso = float.Parse(Console.ReadLine());
								Console.WriteLine("Cargo:");
								f.Cargo = Console.ReadLine();
								Console.WriteLine("Salario:");
								f.Sal = int.Parse(Console.ReadLine());
								Console.WriteLine("data de nascimento");
								Console.Write("dia: ");
								vd = int.Parse(Console.ReadLine());
								Console.Write("mes: ");
								vm = int.Parse(Console.ReadLine());
								Console.Write("ano: ");
								va = int.Parse(Console.ReadLine());

								f.setdatanasc(vd, vm, va);
								lf.Add(f);

								break;
							case 2:
								foreach (funcionario item in lf)
								{
									Console.WriteLine( item.mostraf());
								}
								Console.ReadKey();
								break;
					default:
						break;
				}
				break;
					case 2:
						Console.WriteLine("1-Cadastrar");
						Console.WriteLine("2-Mostrar");
						op2 = int.Parse(Console.ReadLine());
						switch (op2)
						{
							case 1:
								p = new paciente();
								Console.WriteLine("Nome:");
								p.Nome = Console.ReadLine();
								Console.WriteLine("Peso:");
								p.Peso = float.Parse(Console.ReadLine());
								Console.WriteLine("Matricula:");
								p.Matricula = Console.ReadLine();
								Console.WriteLine("data de nascimento");
								Console.Write("dia: ");
								vd = int.Parse(Console.ReadLine());
								Console.Write("mes: ");
								vm = int.Parse(Console.ReadLine());
								Console.Write("ano: ");
								va = int.Parse(Console.ReadLine());

								p.setdatanasc(vd, vm, va);
								lp.Add(p);

								break;
							case 2:
								foreach (paciente item in lp)
								{
									Console.WriteLine(item.mostrapaciente());
								}
								Console.ReadKey();
								break;
					default:
						break;
				}
				break;
					case 3:
						Console.WriteLine("1-Cadastrar");
						Console.WriteLine("2-Associar paciente ao medico");
						Console.WriteLine("3-Mostrar");
						Console.WriteLine("4-Mostrar pacientes de um medico");
						op2 = int.Parse(Console.ReadLine());
						switch (op2)
						{
							case 1:
								m = new medico();
								Console.WriteLine("Nome:");
								m.Nome = Console.ReadLine();
								Console.WriteLine("Peso:");
								m.Peso = float.Parse(Console.ReadLine());
								Console.WriteLine("Especialidade:");
								m.Especialidade = Console.ReadLine();
								Console.WriteLine("data de nascimento");
								Console.Write("dia: ");
								vd = int.Parse(Console.ReadLine());
								Console.Write("mes: ");
								vm = int.Parse(Console.ReadLine());
								Console.Write("ano: ");
								va = int.Parse(Console.ReadLine());

								m.setdatanasc(vd, vm, va);
								lm.Add(m);

								break;
							case 2:
								Console.Write("Digite o nome do medico: ");
								nomemed = Console.ReadLine();

								Console.Write("Digite a nome do paciente: ");
								nomep = Console.ReadLine();

								foreach (paciente item in lp)
								{
									if (nomep == item.Nome)
									{
										foreach (medico it in lm)
										{
											if (nomemed == it.Nome)
											{
												it.registrarp(item);
											}
										}
									}
								}
								break;
							case 3:
								foreach (medico item in lm)
								{
									Console.WriteLine(item.mostramed());
								}
								Console.ReadKey();
								break;
							case 4:
								Console.WriteLine("Nome do medico: ");
								nomemed = Console.ReadLine();

								foreach (medico item in lm)
								{
									if (nomemed==item.Nome)
									{
										Console.WriteLine(item.mostralista());
									 
									}
								}
								Console.ReadKey();
								break;
					default:
						break;
				}
				break;
					case 4:
						foreach (medico item in lm)
						{
							Console.WriteLine(item.mostramed());
						}
						foreach (funcionario item in lf)
						{
							Console.WriteLine(item.mostraf());
						}
						foreach (paciente item in lp)
						{
							Console.WriteLine(item.mostrapaciente());
						}
						Console.ReadKey();
						break;


				default:
						Console.WriteLine("Opçao invalida!");
				break;
			     }
					
			

			} while (op != 5);


		}
	}
}
