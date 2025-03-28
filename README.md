# Kanban Front-End

Este é um projeto de front-end para uma aplicação Kanban, onde é possível visualizar e gerenciar tarefas em três colunas: "A Fazer", "Fazendo" e "Finalizado". O front-end foi desenvolvido em Blazor, utilizando C# e HTML, e faz chamadas para uma API backend para gerenciar e exibir as tarefas.

## Funcionalidades

- **Visualização de Tarefas**: A aplicação permite visualizar tarefas organizadas por status ("A Fazer", "Fazendo", "Finalizado").
- **Carregamento de Tarefas**: O usuário pode inserir seu ID e carregar suas tarefas através da API.
- **Organização de Tarefas**: As tarefas podem ser visualizadas de acordo com seu status atual e movidas entre as colunas.

## Tecnologias

- **Blazor**: Framework da Microsoft para construir UIs interativas utilizando C#.
- **C# e .NET**: Backend em C# com o Blazor para renderização de componentes.
- **HTML/CSS**: Estrutura de layout e design do front-end.

Iniciará o servidor local na URL `https://localhost:7261`. Você poderá acessar a aplicação no navegador.

## Funcionalidade de Carregar Tarefas

- O usuário deve fornecer um **ID de usuário** para carregar as tarefas associadas.
- As tarefas serão recuperadas da API com base no ID do usuário.
- O sistema irá organizar as tarefas em três colunas:
  - **A Fazer**: Tarefas que ainda não foram iniciadas.
  - **Fazendo**: Tarefas que estão sendo trabalhadas.
  - **Finalizado**: Tarefas que foram concluídas.

## API para Tarefas

A aplicação front-end consome uma API para carregar as tarefas. 
A URL da API é configurada como `https://localhost:7196/api/tarefas/{UserId}`, onde `{UserId}` é o ID fornecido pelo usuário. A resposta da API deve ser uma lista de tarefas, com a estrutura a seguir:

```json
{
  "Id": 1,
  "Titulo": "Título da Tarefa",
  "Descricao": "Descrição da tarefa",
  "Status": "A Fazer",
  "Data": "2023-05-01T00:00:00",
  "UserId": 1
}
```

## Estrutura do Front-End

O front-end é dividido em três principais componentes Razor:

1. **Página Principal (`/`)**:
   - Contém um campo de input para inserir o ID do usuário e um botão para carregar as tarefas.
   - Exibe as tarefas nas colunas: **A Fazer**, **Fazendo**, e **Finalizado**.
   
2. **Kanban Column**:
   - Componente que representa uma coluna de tarefas. Cada coluna tem um título e exibe as tarefas de acordo com seu status.

3. **Kanban Card**:
   - Componente que representa uma tarefa individual. Exibe o título e descrição da tarefa, e permite ao usuário mover a tarefa entre os status.
