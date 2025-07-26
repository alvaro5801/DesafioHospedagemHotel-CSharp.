# 🏨 Sistema de Hospedagem de Hotel em C#

![Status](https://img.shields.io/badge/status-conclu%C3%ADdo-brightgreen)

Este é um projeto de console simples desenvolvido em C# como parte de um desafio de programação. O objetivo é simular um sistema básico de reserva de hotel, aplicando conceitos fundamentais de Programação Orientada a Objetos (POO).

## ✨ Funcionalidades

- Cadastro de suítes com tipo, capacidade e valor da diária.
- Cadastro de hóspedes (uma ou mais pessoas por reserva).
- Criação de uma reserva, associando hóspedes a uma suíte por um determinado número de dias.
- Validação que impede a reserva de mais hóspedes do que a capacidade da suíte.
- Cálculo do valor total da hospedagem com uma regra de negócio: um desconto de 10% é aplicado para estadias com mais de 10 dias.

## 🛠️ Tecnologias e Conceitos Aplicados

- **Linguagem:** C#
- **Plataforma:** .NET 8
- **Paradigma:** Programação Orientada a Objetos (POO)
- **Conceitos de POO:**
  - **Classes e Objetos:** Modelagem das entidades `Pessoa`, `Suite` e `Reserva`.
  - **Encapsulamento:** Agrupamento de propriedades e métodos que representam o estado e o comportamento dos objetos.
  - **Construtores:** Utilização de construtores para garantir a criação de objetos em um estado válido e consistente.
  - **Listas (`List<T>`):** Manipulação de coleções de objetos para representar os múltiplos hóspedes de uma reserva.
  - **Tratamento de Exceções:** Uso de `throw new Exception` para lidar com regras de negócio inválidas (ex: excesso de hóspedes).

## 🚀 Como Rodar o Projeto

**Pré-requisitos:**
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.
- [Git](https://git-scm.com/downloads) instalado.

**Passo a passo:**

1.  **Clone o repositório (lembre-se de usar a URL do seu próprio repositório!):**
    ```bash
    git clone [https://github.com/seu-usuario/DesafioHospedagemHotel-CSharp.git](https://github.com/seu-usuario/DesafioHospedagemHotel-CSharp.git)
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd DesafioHospedagemHotel-CSharp
    ```

3.  **Execute o programa:**
    ```bash
    dotnet run
    ```
    A saída no console mostrará o resultado dos dois cenários de teste programados.

## 🏛️ Estrutura do Projeto

O sistema é composto por 4 classes principais:

- **`Pessoa.cs`**: Representa um único hóspede com `Nome` e `Sobrenome`.
- **`Suite.cs`**: Representa um quarto de hotel com `TipoSuite`, `Capacidade` e `ValorDiaria`.
- **`Reserva.cs`**: Classe central que conecta uma `Suite` a uma `List<Pessoa>` por um número de `DiasReservados`. Contém a lógica de negócio para validação e cálculo de valores.
- **`Program.cs`**: Ponto de entrada da aplicação (`Main`), onde os cenários de teste são criados e executados.
