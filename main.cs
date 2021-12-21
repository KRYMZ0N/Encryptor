using System;

class Program {

  public static void Main (string[] args) {
    Console.WriteLine("Type");
    String Input = Console.ReadLine().ToLower();


    for (int i = 0; i < Input.Length; i++) {
      switch (Input) {
        case string a when a.Contains("a"):
        Input = Input.Replace("a", "u");
        break;

        case string b when b.Contains("b"):
        Input = Input.Replace("b", "t");
        break;

        case string c when c.Contains("c"):
        Input = Input.Replace("c", "1");
        break;

        case string d when d.Contains("d"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("e"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("f"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("g"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("h"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("i"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("j"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("k"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("l"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("m"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("n):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("o"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("p"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("q"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("r"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("s"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("t"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("u"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("v"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("w"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("x"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("y"):
        Input = Input.Replace("d", "o");
        break;

        case string d when d.Contains("z"):
        Input = Input.Replace("d", "o");
        break;

        default:
        Console.WriteLine("Fuck Off");
        break;
      }
      Console.WriteLine("added 1 to i. i now equals: " + i);
    }

  Console.WriteLine(Input);
  }
}