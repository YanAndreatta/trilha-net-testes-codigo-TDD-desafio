# Desafio de Testes Unitários para uma Calculadora em C#

Este projeto contém uma série de testes unitários para a classe `Calculadora`. Os testes foram implementados utilizando o framework xUnit e cobrem diversas operações matemáticas básicas, além de funcionalidades adicionais da calculadora.

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

- **Namespace:** `NewTalentsTest`
- **Classe de Teste:** `UnitTest1`
- **Classe da calculadora:** `Calculadora`

## Testes Implementados

### 1. Teste de Soma

Testa a operação de soma da calculadora.

```csharp
[Theory]
[InlineData(1, 2, 3)]
[InlineData(4, 5, 9)]
public void TesteSomar(int val1, int val2, int resultado)
{
    Calculadora calc = ConstruirClasse();
    int resultadoCalculadora = calc.Somar(val1, val2);
    Assert.Equal(resultado, resultadoCalculadora);
}
```
### 2. Teste de Multiplicação

Testar a operação de multiplicação da calculadora.

```csharp
[Theory]
[InlineData(1, 2, 2)]
[InlineData(4, 5, 20)]
public void TesteMultiplicar(int val1, int val2, int resultado)
{
    Calculadora calc = ConstruirClasse();
    int resultadoCalculadora = calc.Multiplicar(val1, val2);
    Assert.Equal(resultado, resultadoCalculadora);
}
```

### 3. Teste de Divisão

Testa a operação de divisão da calculadora.

```csharp
[Theory]
[InlineData(6, 2, 3)]
[InlineData(5, 5, 1)]
public void TesteDividir(int val1, int val2, int resultado)
{
    Calculadora calc = ConstruirClasse();
    int resultadoCalculadora = calc.Dividir(val1, val2);
    Assert.Equal(resultado, resultadoCalculadora);
}
```

### 4. Teste de Subtração

Testa a operação de subtração da calculadora.

```csharp
[Theory]
[InlineData(6, 2, 4)]
[InlineData(5, 5, 0)]
public void TesteSubtrair(int val1, int val2, int resultado)
{
    Calculadora calc = ConstruirClasse();
    int resultadoCalculadora = calc.Subtrair(val1, val2);
    Assert.Equal(resultado, resultadoCalculadora);
}
```

### 5. Teste de Divisão por Zero

Testa o tratamento de exceção ao tentar dividir por zero.

```csharp
[Fact]
public void TestarDivisaoPorZero()
{
    Calculadora calc = ConstruirClasse();
    Assert.Throws<DivideByZeroException>(() => calc.Dividir(5, 0));
}
```

### 6. Teste de Histórico de Operações

Testa se o histórico de operações da calculadora está sendo armazenado corretamente.

```csharp
[Fact]
public void TestarHistorico()
{
    Calculadora calc = ConstruirClasse();
    calc.Somar(1, 2);
    calc.Somar(2, 8);
    calc.Somar(3, 7);
    calc.Somar(4, 1);

    var lista = calc.Historico();
    Assert.NotEmpty(lista);
    Assert.Equal(3, lista.Count);
}
```

# Como Executar os Testes
Para executar os testes, certifique-se de ter o xUnit instalado e configurado no seu ambiente de desenvolvimento. Em seguida, execute o comando apropriado para rodar os testes, dependendo do seu ambiente de desenvolvimento (Visual Studio, CLI, etc.).

Exemplo utilizando a CLI do .NET:

```bash
dotnet test
```