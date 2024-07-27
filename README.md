FinanceControl
FinanceControl é um sistema de controle de fluxo de caixa diário que permite registrar lançamentos (débitos e créditos) e consultar o saldo diário consolidado. O sistema foi desenvolvido utilizando C#, princípios SOLID, padrões de design, padrões de arquitetura em camadas e testes unitários com XUnit.

Funcionalidades
Registro de lançamentos (débitos e créditos)
Consulta de saldo diário consolidado
Geração de relatório com saldo diário
Requisitos
.NET Core SDK 3.1 ou superior
Banco de dados SQL Server
Estrutura do Projeto
A solução está dividida em vários projetos, cada um com uma responsabilidade específica:

FinanceControl.Api: API principal.
FinanceControl.Application: Contém a lógica de aplicação.
FinanceControl.Domain: Entidades e regras de negócio.
FinanceControl.Infrastructure: Acesso a dados.
FinanceControl.Tests: Testes unitários.
Arquitetura
O projeto segue a arquitetura em camadas:

Camada de Apresentação (API): Controladores que recebem as requisições HTTP.
Camada de Aplicação: Implementações de serviços que contêm a lógica de negócios.
Camada de Domínio: Entidades e regras de negócio.
Camada de Infraestrutura: Repositórios e acesso a dados.

Configuração e Execução
1. Clonar o Repositório

git clone https://https://github.com/frngoliveira/FinanceControl.git
cd financecontrol

2. Configurar o Banco de Dados
Configure a conexão com o banco de dados SQL Server no arquivo appsettings.json do projeto FinanceControl.Api:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=seu-servidor;Database=FinanceControlDb;User Id=seu-usuario;Password=sua-senha;"
  }
}

3. Executar Migrações
Navegue até o projeto FinanceControl.Api e execute as migrações para criar o banco de dados:

dotnet ef database update

4. Executar a Aplicação
No diretório raiz do projeto, execute o comando:

dotnet run --project FinanceControl.Api

A API estará disponível em https://localhost:5001.

5. Executar Testes
Para executar os testes unitários, navegue até o projeto FinanceControl.Tests e execute:

dotnet test

Exemplos de Uso
Registrar Lançamento
Endpoint: POST /api/lancamentos

Request Body:

{
  "valor": 100.0,
  "data": "2023-07-16T00:00:00",
  "tipo": "Credito"
}

Resposta:

{
  "id": "guid-do-lancamento",
  "valor": 100.0,
  "data": "2023-07-16T00:00:00",
  "tipo": "Credito"
}

Consultar Lançamentos por Data
Endpoint: GET /api/lancamentos?data=2023-07-16

Resposta:

{
  "id": "guid-do-lancamento",
  "valor": 100.0,
  "data": "2023-07-16T00:00:00",
  "tipo": "Credito"
}

Consultar Saldo Diário Consolidado
Endpoint: GET /api/consolidacao?data=2023-07-16

Resposta:
{
  "saldo": 100.0
}

Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias e correções.
