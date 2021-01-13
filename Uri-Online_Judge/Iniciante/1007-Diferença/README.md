# Diferença
---
Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).


####Entrada
O arquivo de entrada contém 4 valores inteiros.

####Saída
Imprima a mensagem <strong>DIFERENCA</strong> com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.

| Exemplo de Entrada | Exemplo de Saída |
| ------------------ | ---------------- |
| 5<br>6<br>7<br>8   | DIFERENCA = -26  |
| 0<br>0<br>7<br>8   | DIFERENCA = -56  |
| 5<br>6<br> -7<br>8 | DIFERENCA = 86   |
----

Python
```py
A = int(input())
B = int(input())
C = int(input())
D = int(input())

DIFERENCA = (A * B - C * D)


print('DIFERENCA =', DIFERENCA))

```
C#
```cs
using System; 

class URI {

    static void Main(string[] args) {
        
        Int32 A, B, C, D;
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        D = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("DIFERENCA = "+((A * B) - (C * D)));

    }
}
```