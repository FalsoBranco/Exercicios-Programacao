# Soma Simples

 Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável <strong>SOMA</strong>. A seguir escrever o valor desta variável.

## Entrada
O arquivo de entrada contém 2 valores inteiros.
## Saida
Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor correspondente à soma de A e B. Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

---

| Exemplo de Entrada | Exemplo de Saída |
| ------------------ | ---------------- |
| 30<br>10           | SOMA = 40        |
| -30<br>10          | SOMA = -20       |
| 0<br>0             | SOAM = 0         |

----

python
```py
A = int(input())
B = int(input())

SOMA = A + B

print('SOMA =', SOMA)


```
C#
```cs
using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, soma;
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        soma = A + B;
        Console.WriteLine("SOMA = " + soma.ToString());

    }

}
```
