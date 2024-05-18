# Projeto .NET Core: Código Limpo e Organizado

Este projeto foi desenvolvido como parte de um exercício de boas práticas em desenvolvimento .NET Core. O objetivo é demonstrar a aplicação de técnicas de código limpo e organizado, utilizando um exemplo prático de um sistema de gerenciamento de produtos.

## Visão Geral

O projeto foca em criar um sistema que utiliza boas práticas de programação, incluindo a separação de responsabilidades, injeção de dependência, comentários XML e o uso de DTOs (Data Transfer Objects). Este projeto foi um teste para ser aprovado em um cliente na consultoria AlterSolutions.

## Exemplos de Código Limpo

### 1. Separação de Responsabilidades (SRP)

A separação clara das responsabilidades é uma prática essencial para a escalabilidade e manutenção do código. No nosso projeto, dividimos as responsabilidades em três camadas principais:

- **Controller**: Lida com as requisições HTTP.
- **Service**: Contém a lógica de negócios.
- **Repository**: Gerencia as interações com o banco de dados.
