## ORM
 - Object Relational Mapping
 - Mapeamento Objeto/ Relacional
 - Responsável por fazer o De-Para
 - Parte essencial do Entity framework
 - Similar ao **Dapper**
## Entity Framework
 - Um framework é um conjunto de bibliotecas
 - Muito mais poderoso do que o **Dapper**
 - Mais complexo e mais Pesado
 - Permite trabalhar com
    - **CRUD**
    - **Migrações**

 **Quando usar Entity e quando usar Dapper?**
 - Projetos rápidos utilizar **Dapper**
 - Projetos complexos, usar **Entity Framework**
 - Não existe bala de prata na programação, **tudo depende do contexto**
 - **Entity Framework** é um **framework** que utiliza o **ORM**
 - **Dapper** é um **ORM**

## Code first ou Database First?
 ### Database First
  - Banco já está feito
  - Mapeamos o que já existe para os novos objetos criados
 ### Code First
  - Também conhecido como Model First
  - Começamos pelo código
  - Geramos o banco automaticamente via **Migrations**
  - Modelo amplamente usado
## Data Context
 - Um objeto no Entity Framework precisa de um **contexto**
 - Chamado de Data Context
 - **Define o Banco de dados em memória**
 - É composto por subconjuntos de dados
  - Chamado de **DbSet**
## Mapeamento
   - É o de - para
   - Diz qual classe no C# se refere a qual tabela no banco de dados
   - Diz quais propriedades da classe se referem a quais colunas no banco de dados
   - Informa o tipo de dados
   - **Permite gerar o banco automaticamente**
### Data Annotations
   - **Fluent Mapping**
      - Mapeamento Fluente
      - Feito em uma classe externa
      - Não "polui" a classe principal
      - Não cria dependências para o projeto/classe principal
   - **Data Annotations**
      - Feito diretamente nas classes
      - Mais simples e direto
      - Dependem do System.ComponentModel.DataAnnotations
      - Alguns dependem do Microsoft.EntityFrameworkCore
      - Gera os "METADADOS"