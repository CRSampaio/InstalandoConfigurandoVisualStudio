# Curso DIO: Instalando e configurando o Visual Studio

## Anotações

- Ao criarmos um repositório do Git utilizando o Visual Studio, ele gera automaticamente dois arquivos, .gitignore e .gitattributes.

- Também é possível através de uma GUI já fazer o push no repositório de maneira simples e fácil.

### Criando Testes no Visual Studio 2019

- Vamos criar um novo projeto para fazermos nossos testes.
- Vamos configurar cada método com o padrão AAA (Arrange, Act, Assert).
  - Arrange: Essa seção irá ter um teste de unidade que instanciará e populará os objetos que são passados para o método sendo testado.
  - Agir: Essa seção invocará o método sendo testado com os parâmetros organizados.
  - Assert: Verificará a ação do método em teste se comporta conforme o esperado.
- É possível criar os testes unitários clicando com o botão direto na classe que você está editando. Será criado um metódo de teste para cada metódo que houver na classe.

- Entrando na opçao Test -> Run All Tests, será possível executar os metódos de teste.
