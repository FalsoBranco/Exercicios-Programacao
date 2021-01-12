# Extremamente Básico

---

Leia 2 valores inteiros e armazene-os nas variáveis <strong>A</strong> e <strong>B</strong>. Efetue a soma de <strong>A</strong> e <strong>B</strong> atribuindo o seu resultado na variável <strong>X</strong>. Imprima <strong>X</strong> conforme exemplo apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo especificado e não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "<em>Presentation Error</em>".


## Entrada
A entrada contém 2 valores inteiros.

## Saida
Imprima a mensagem "X = " (letra X maiúscula) seguido pelo valor da variável <strong> X </strong> e pelo final de linha. Cuide para que tenha um espaço antes e depois do sinal de igualdade, conforme o exemplo abaixo. 

---

| Exemplo de Entrada | Exemplo de Saída |
| ------------------ | ---------------- |
| 10<br>9            | X = 19           |
| -10<br>4           | X = -6           |
| 15<br>-7           | X = 8            |
----

python
```py
A = int(input())
B = int(input())

X = A + B

print('X =', X)

```
C#
```cs
using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, X;
            A = Int32.Parse(Console.ReadLine());
            B = Int32.Parse(Console.ReadLine());
            X = A + B;
            Console.WriteLine("X = " + X);

    }

}

```
