# Área do Círculo


---

A fórmula para calcular a área de uma circunferência é: <strong>area = π . raio<sup>2</sup></strong>. Considerando para este problema que <strong>π = </strong> 3.14159:
Efetue o cálculo da área, elevando o valor de <strong>raio</strong> ao quadrado e multiplicando por <strong>π</strong>.

## Entrada
A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável <strong>raio</strong>.

## Saida
Apresentar a mensagem "A=" seguido pelo valor da variável <strong>area</strong>, conforme exemplo abaixo, com 4 casas após o ponto decimal. Utilize variáveis de dupla precisão (double). Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

---

| Exemplo de Entrada | Exemplo de Saída |
| ------------------ | ---------------- |
| 2.00               | A=12.5664        |
| 100.64             | A=31819.3103     |
| 150.00             | A=70685.7750     |

----

python
```py
R = float(input())
π = 3.14159

A = π * R ** 2
print("A={:.4f}".format(A))


```
C#
```cs
using System; 

class URI {

    static void Main(string[] args) { 

        double R = Convert.ToDouble(Console.ReadLine());
        double A = 3.14159 * R * R;
        Console.WriteLine("A=" + A.ToString("0.0000"));

    }

}

```
