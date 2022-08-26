Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

int GetNat(int a1, int b1)
{ int S = a1;
    
            if (a1 == b1)
            {
                return S;
            }
            S = S + GetNat(a1 + 1, b1);
            return S;
       

}
Console.WriteLine(GetNat(n, m));
