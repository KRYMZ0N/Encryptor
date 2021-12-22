using System;

class Program {

  public static void Main (string[] args) {
    Console.WriteLine("Type");
    String Input = Console.ReadLine().ToLower();


    for (int I = 0; I < Input.Length; I++) {
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

        case string e when e.Contains("e"):
        Input = Input.Replace("e", "p");
        break;

        case string f when f.Contains("f"):
        Input = Input.Replace("f", "n");
        break;

        case string g when g.Contains("g"):
        Input = Input.Replace("g", "l");
        break;

        case string h when h.Contains("h"):
        Input = Input.Replace("h", "g");
        break;

        case string i when i.Contains("i"):
        Input = Input.Replace("i", "q");
        break;

        case string j when j.Contains("j"):
        Input = Input.Replace("j", "w");
        break;

        case string k when k.Contains("k"):
        Input = Input.Replace("k", "h");
        break;

        case string l when l.Contains("l"):
        Input = Input.Replace("l", "z");
        break;

        case string m when m.Contains("m"):
        Input = Input.Replace("m", "a");
        break;

        case string n when n.Contains("n"):
        Input = Input.Replace("n", "i");
        break;

        case string o when o.Contains("o"):
        Input = Input.Replace("o", "b");
        break;

        case string p when p.Contains("p"):
        Input = Input.Replace("p", "c");
        break;

        case string q when q.Contains("q"):
        Input = Input.Replace("q", "r");
        break;

        case string r when r.Contains("r"):
        Input = Input.Replace("r", "a");
        break;

        case string s when s.Contains("s"):
        Input = Input.Replace("s", "f");
        break;

        case string t when t.Contains("t"):
        Input = Input.Replace("t", "k");
        break;

        case string u when u.Contains("u"):
        Input = Input.Replace("u", "l");
        break;

        case string v when v.Contains("v"):
        Input = Input.Replace("v", "5");
        break;

        case string w when w.Contains("w"):
        Input = Input.Replace("w", "2");
        break;

        case string x when x.Contains("x"):
        Input = Input.Replace("x", "3");
        break;

        case string y when y.Contains("y"):
        Input = Input.Replace("y", "7");
        break;

        case string z when z.Contains("z"):
        Input = Input.Replace("z", "9");
        break;

        default:
        Console.WriteLine("not work");
        break;
      }
      Console.WriteLine("added 1 to i. i now equals: " + I);
    }

  Console.WriteLine(Input);
  }
}