# Produto Simples
---
Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável <strong>PROD</strong>. A seguir mostre a variável <strong>PROD</strong> com mensagem correspondente.


####Entrada
O arquivo de entrada contém 2 valores inteiros.

####Saída
Imprima a mensagem "PROD" e a variável <strong>PROD</strong> conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade. Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: <em>“Presentation Error”.

| Exemplo de Entrada | Exemplo de Saída |
| ------------------ | ---------------- |
| 3<br>9             | SOMA = 27        |
| -30<br>10          | SOMA = -300      |
| 0<br>9             | SOAM = 0         |
----

Python
```py
A = int(input())
B = int(input())

PROD = A * B
print('PROD =', PROD)
```
C#
```cs
using System; 

class URI {

    static void Main(string[] args) { 
        int.TryParse(Console.ReadLine(),out int a);
        int.TryParse(Console.ReadLine(), out int b);
        Console.WriteLine($"PROD = {a * b}");
    }
}
```