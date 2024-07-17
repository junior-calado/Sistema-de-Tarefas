# Sistema de Tarefas - API em C#

## Descrição

Este projeto é uma API de Sistema de Tarefas desenvolvida em C# utilizando ASP.NET Core. A API permite o cadastro de usuários e o gerenciamento de tarefas, incluindo a criação, atualização, deleção e listagem tanto de tarefas quanto de usuários. Também possui a funcionalidade de relacionar uma tarefa e atribuí-la a um determinado usuário. A interface do Swagger está integrada para facilitar a interação e teste dos endpoints. Esta implementado tambem uma rota da API ViaCep, onde eu consumi a API para retornar informações de acordo com o CEP que eu passar.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** ASP.NET Core
- **Banco de Dados:** SQL Server
- **API ViaCep:** https://viacep.com.br

## Funcionalidades

- **CRUD de Usuarios:** 
  - Criação de novos Usuarios.
  - Atualização de Usuarios existentes.
  - Deleção de Usuario.
  - Listagem de todos os usuarios.

- **CRUD de Tarefas:** 
  - Criação de novas tarefas.
  - Criação de tarefas relacionadas/atribuidas a um usuario.
  - Atualização de tarefas existentes.
  - Deleção de tarefas.
  - Listagem de todas as tarefas.
 
- **BUSCA DE CEP:** 
  - Retorna informações de acordo com o CEP que for passado.

## Pré-requisitos

- .NET SDK 6.0 ou superior
- SQL Server


