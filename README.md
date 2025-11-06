Este é um aplicativo web simples, construído com Blazor (C# e .NET), que exibe o resultado da última partida oficial de futebol do Grêmio.
Ele foi criado para ser uma ferramenta rápida e limpa, que vai direto ao ponto: mostrar o placar mais recente.

Sobre o Projeto
Este projeto foi desenvolvido como um exercício prático para aprender a consumir dados de uma API externa (Web API) e exibi-los em uma interface de usuário moderna com .NET.
O foco foi entender o fluxo completo:
Fazer uma requisição HTTP autenticada para uma API de esportes.
Receber os dados em formato JSON.
"Traduzir" (desserializar) esse JSON complexo para classes C# simples (Models).
Usar um Serviço (Service) para organizar a lógica de busca.
Exibir os dados na página Blazor de forma assíncrona.

Funcionalidades
Exibe o placar final do último jogo concluído.
Mostra contra quem foi o jogo (Adversário).
Informa o local (Estádio) e a data da partida.
Calcula e exibe se o resultado foi "Vitória", "Empate" ou "Derrota".
Exibe uma mensagem "Carregando..." enquanto busca os dados, e uma mensagem de erro se a API falhar.

Tecnologias Utilizadas
Framework: Blazor Web App (.NET 8+)
Linguagem: C#
Comunicação API: HttpClient
Mapeamento de Dados: System.Text.Json
Fonte de Dados: API Externa: football-data.org
