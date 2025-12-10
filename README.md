# Avaliacao-Tecnica-em-CSharp-e-.NET


Avaliação Técnica .NET
O objetivo da atividade é avaliar o nível técnico, sendo assim mesmo que não consiga executar alguma atividade não desanime, o que iremos avaliar é o processo realizado e até onde chegou com a atividade. 

O tempo de resolução média para Junior é de 6 à 12 horas,  Pleno é 4 à 7 horas e Sênior de 3 à 4 horas.
Loja do seu Manoel


Seu Manoel tem uma loja de jogos online e deseja automatizar o processo de embalagem dos pedidos. Ele precisa de uma API que, dado um conjunto de pedidos com produtos e suas dimensões, retorne quais caixas devem ser usadas para cada pedido e quais produtos irão em cada caixa.

Descrição do Problema:

Desenvolva uma API WEB que receba, em formato JSON, uma lista de pedidos. Cada pedido contém uma lista de produtos, cada um com suas dimensões (altura, largura, comprimento). A API deve processar cada pedido e determinar a melhor forma de embalar os produtos, selecionando uma ou mais caixas para cada pedido e especificando quais produtos vão em cada caixa.

Caixas Disponíveis:

Seu Manoel possui os seguintes tamanhos de caixas pré-fabricadas (altura, largura, comprimento):

Caixa 1: 30 x 40 x 80
Caixa 2: 80 x 50 x 40
Caixa 3: 50 x 80 x 60
Entrada e saída do endpoint:

Entrada: A API deve aceitar um JSON contendo N pedidos diferentes. Cada pedido deve ter entre N produtos. Cada produto deve incluir suas dimensões em centímetros (altura, largura, comprimento).

Processamento: Para cada pedido, a API deve calcular a melhor forma de empacotar os produtos, podendo usar uma ou mais caixas disponíveis. Deve considerar a otimização do espaço, tentando minimizar o número de caixas usadas.

Saída: A API deve retornar um JSON que, para cada pedido, lista as caixas usadas e quais produtos foram colocados em cada caixa.

Exemplo de entrada: entrada.json

Exemplo de saída: saida.json



Requisitos para entrega:
1 - Fazer microserviço em .NET Core ou superior utilizando banco de dados SQL Server;
2 - Tanto o serviço como o banco de dados deve rodar via docker;
3 - Deve conter REAME.md com os pré-requisitos (provavelmente apenas o docker) e comandos necessários para rodar a aplicação, recomendado utilizar o “docker-compose”
4 - A API precisa ter swagger e ser possível testar ela a partir do swagger;
5 - Enviar o código fonte via link do repositório do github;

Requisitos Opcionais:
1 - Segurança na autenticação da API
2 - Deve conter teste unitário
