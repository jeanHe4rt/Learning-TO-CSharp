using System.Diagnostics;

int result = Fibonati(6);
Console.WriteLine(result);

static int Fibonati(int n)
{
  int n1 = 0;
  int n2 = 1;
  int sum;

  for (int i = 2; i < n; i++)
  {
    sum = n1 + n2;
    n1 = n2;
    n2 = sum;
  };
  
  Debug.Assert(n2 ==5,"O retorno do valor não é 5 porém deveria ser.");
  return n == 0 ? n1 : n2;
}