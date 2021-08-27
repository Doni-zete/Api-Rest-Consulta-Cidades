using System;

namespace series
{
  class Program
  {

static Serie repositorio = new SerieRepositotio();
    static void Main(string[] args)
    {

      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "x")
      {
        switch (opcaoUsuario)
        {
          case "1":
            ListarSeries();
            break;
          case "2":
            InserirSerie();
            break;
          case "3":
            AtualizzarSerie();
            break;
          case "4":
            ExcluirSerie();
            break;
          case "5":
            VisualizarSerie();
            break;
          case "C":
            Console.Clear();
            break;

          default:

            throw new ArgumentOutOfRangeException();
        }

        opcaoUsuario = ObterOpcaoUsuario();
      }

      private static void ListarSeries();
      {
        System.Console.WriteLine("Listar séries");

        var lista  = repositorio.Lista();
        if(lista.Count ==0)
        {
          System.Console.WriteLine( "Nenhuma série cadastrada.");
          return;
        }
        foreach(var serie in lista)
        {
          System.Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
        }

      }

      private static void InserirSerie();

      Console.WriteLine("Inserir nova Serie");
      //https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1

        foreach (int i in Enum.GetValues(typeof (Genero)))

        {
          System.Console.WriteLine("{0}-{1}",1, Enum.GetName(typeof(Genero),i));
        }
        System.Console.Write("Digite o genêro entre as opçoes acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        System.Console.Write("Digite o Título da Série: ");
        int entradaTitulo = Console.ReadLine();

        System.Console.Write("Digite o Ano de Início da Série: ");
        int entradaAno = int.Parse(Console.ReadLine());

        System.Console.Write("Digite a Descrição da Série: ");
        int entradaDescricao = int.Parse(Console.ReadLine());





        private static string ObterOpcaoUsuario();
        {
        System.Console.WriteLine();
        System.Console.WriteLine("Dio series a seu dispor!!!");
        System.Console.WriteLine("Informe a opcao desejada:");

        System.Console.WriteLine("1- Listar séries");
        System.Console.WriteLine("2- Inserir nova série");
        System.Console.WriteLine("3- Atualizar série");
        System.Console.WriteLine("4- Excluir série");
        System.Console.WriteLine("5- Visualizar série");
        System.Console.WriteLine("C- Limpar  ");

        }
      }
    }

    private static string ObterOpcaoUsuario()
    {
      throw new NotImplementedException();
    }
  }
