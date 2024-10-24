
# Projeto TDD - Calculadora com Histórico de Operações

Este projeto demonstra a aplicação de TDD (Test-Driven Development) na criação de uma calculadora básica em C#. A calculadora possui funcionalidades de soma, subtração, multiplicação e divisão, além de armazenar o histórico das operações realizadas. Os testes foram desenvolvidos utilizando o framework xUnit para garantir a confiabilidade das operações.

## Funcionalidades

- **Somar**: Adiciona dois números inteiros.
- **Subtrair**: Subtrai dois números inteiros.
- **Multiplicar**: Multiplica dois números inteiros.
- **Dividir**: Divide dois números inteiros (com tratamento de exceção para divisão por zero).
- **Histórico**: Armazena as últimas três operações realizadas.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação.
- **.NET**: Plataforma de desenvolvimento.
- **xUnit**: Framework de testes unitários.

## Estrutura do Projeto

- **Servicos/Calculadora.cs**: Contém a classe `Calculadora` com as operações matemáticas e o armazenamento de histórico.
- **ProjetoTDDTeste/ProjetoTDDTeste.cs**: Contém os testes unitários para validar as funcionalidades da calculadora.

## Como Executar o Projeto

### Pré-requisitos

- .NET SDK 3.1 Core ou superior instalado.

### Passos

1. Clone o repositório para sua máquina local:

   ```bash
   git clone <URL-do-repositorio>
   ```

2. Navegue até a pasta do projeto:

   ```bash
   cd ProjetoTDD
   ```

3. Execute os testes:

   ```bash
   dotnet test
   ```

Os testes verificarão se todas as operações matemáticas estão funcionando corretamente, incluindo o tratamento de exceção para a divisão por zero e o limite de três operações no histórico.

## Testes

Os testes foram criados utilizando a biblioteca **xUnit**. O projeto cobre as seguintes áreas:

- **Somar**: Verifica se a soma de dois números retorna o resultado esperado.
- **Subtrair**: Valida se a subtração de dois números está correta.
- **Multiplicar**: Confirma a multiplicação de dois números.
- **Dividir**: Testa a divisão entre dois números, com tratamento de exceção para divisão por zero.
- **Histórico**: Garante que o histórico armazena as últimas três operações realizadas.

### Exemplo de Teste

```csharp
[Theory]
[InlineData(1, 2, 3)]
[InlineData(5, 4, 9)]
public void DeveMandarDoisNumerosERetornarASomaEmInteiro(int x, int y, int esperado)
{
    // Arrange
    Calculadora calc = InstanciaCalculadora();

    //Act
    int resultadoOperacao = calc.Somar(x, y);

    //Assert
    Assert.Equal(esperado, resultadoOperacao);
}
```

## Histórico de Versionamento

- **v1.0.0**: Primeira versão do projeto com operações básicas e testes unitários.

## Contato

Para mais informações, entre em contato:

- **Nome**: Vinicius Cazuza
- **LinkedIn**: [linkedin.com/in/viniciuscazuza](https://www.linkedin.com/in/viniciuscazuza)
- **Instagram**: [instagram.com/vini_cazuza](https://instagram.com/vini_cazuza)

