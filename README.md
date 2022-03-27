<p align="center">
  <a href="https://www.smarthint.co/" target="blank"><img src="https://www.smarthint.co/wp-content/uploads/2021/01/smarthint-logo-white-color.png" width="320" alt="Smart Hint Logo" /></a>
</p>


## Como rodar

```bash
Dentro do seu console do Gerenciador de pacotes, rode:

Add-Migration BancoTesteHint -Context BancoContext

Update-Database -Context BancoContext

ou execute esse script no banco.

create database bancotestehint

CREATE TABLE `clientes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  `Email` text NOT NULL,
  `Telefone` text NOT NULL,
  `Date` datetime NOT NULL,
  `Tipo` text NOT NULL,
  `Cpf` text,
  `Cnpj` text,
  `Estadual` text,
  `Isento` tinyint(1) NOT NULL,
  `Genero` text,
  `Nascimento` text,
  `Bloqueado` tinyint(1) NOT NULL,
  `Senha` text NOT NULL,
  PRIMARY KEY (`Id`)
)
```
## Filtro por todos os campos e ordenação.

https://user-images.githubusercontent.com/49081127/160300124-38e147c9-8f8f-4197-980d-3e4ab400c505.mp4



## Tudo oque foi feito nesse teste.

```bash
O projeto deverá ser desenvolvido de acordo com as especificações abaixo:
Listagem de Compradores
a. A tela deverá possuir a seguinte descrição "Consulte os seus Clientes cadastrados na
sua Loja ou realize o cadastro de novos Cliente";
b. Ao lado direito da área de descrição, deverá ser apresentado o botão "Adicionar Cliente".
c. Quando o Usuário-Lojista selecionar o botão "Filtrar", deverá ser apresentada a área de
pesquisa de Compradores.
d. Deverão ser apresentadas as seguintes opções para o Usuário-Lojista:
■ Nome/Razão Social:
● Campo do tipo input que deverá realizar o filtro considerando o Nome ou Razão
Social dos Compradores;
● Placeholder: Nome ou Razão Social do Cliente.
■ E-mail:
● Campo do tipo input que deverá realizar o filtro considerando o e-mail cadastrado
para os Compradores;
● Placeholder: E-mail do Cliente.
■ Telefone:
● Campo do tipo input que deverá realizar o filtro considerando o telefone cadastrado
para os Compradores;
● Placeholder: Telefone do Cliente
■ Data de Cadastro:
● Campo do tipo date picker que deverá realizar o filtro considerando a Data de
Cadastro do Comprador;
● Placeholder: Selecione uma data ou período.
■ Cliente bloqueado:
● Campo do tipo combobox que deverá retornar às opções SIM e NÃO e deverá
realizar o filtro considerando se os Compradores estão bloqueados ou não.
e. Quando o Usuário-Lojista selecionar o botão "Limpar filtros", todos os dados
inseridos/selecionados deverão ser limpos;
f. Quando o Usuário-Lojista selecionar o botão "Aplicar filtros", deverá ser realizado o filtro
no grid de acordo com os dados inseridos/selecionados;
g. Quando o filtro for aplicado, a área de filtros deverá ser fechada;
h. O Usuário-Lojista poderá retirar um filtro selecionando o botão de deleção do filtro,
quando este cenário ocorrer, uma nova pesquisa deverá ser realizada entre os Clientes;
i. Abaixo da descrição, deverá ser exibido um grid com todos os Compradores cadastrados
na Loja, este que deverá possuir as seguintes colunas:
■ Checkbox - Quando o Usuário-Lojista selecionar o checkbox do cabeçalho do grid,
todos os Compradores deverão ser selecionados, caso ele selecione em uma linha,
somente o Comprador da linha deverá ser selecionado;
■ Nome/Razão Social - Deverá ser retornado o Nome do Comprador, em caso de um
Comprador do tipo Pessoa Física e a Razão Social do Comprador, em caso de um
Comprador do tipo Pessoa Jurídica;
■ E-mail - Deverá ser retornado o e-mail cadastrado para o Comprador;
■ Telefone - Deverá ser retornado o telefone cadastrado para o Comprador;
■ Data de cadastro - Deverá ser retornada a data de cadastro do Comprador, este que
deverá seguir o padrão DD/MM/AAAA;
■ Bloqueado - Coluna do tipo checkbox que poderá ser editada pelo Usuário-Lojista e
informará se o Comprador está ou não bloqueado;
■ Ações - Deverá ser apresentado o botão de edição para os Compradores.
j. Quando o Usuário-Lojista selecionar o botão de edição, o mesmo deverá ser
redirecionado para a tela de Edição do Comprador selecionado;
k. Abaixo do grid, deverá ser apresentada o pagination;
l. Deverão retornar 20 (vinte) compradores por página.
Cadastro de Clientes
m. Quando o Usuário-Lojista selecionar o botão Adicionar Cliente, deverá ser direcionado
para a tela de Adicionar Cliente.
n. Caso o Usuário-Lojista selecione o botão "Voltar", o mesmo deverá ser redirecionado
para a tela de Clientes;
o. Na área principal do cadastro, deverão ser apresentados os seguintes campos:
■ Nome do Cliente/Razão Social:
● Campo obrigatório do tipo input que deverá receber caracteres alfa-numéricos
com no máximo 150 (cento e cinquenta) caracteres;
● Tooltip: Nome completo ou Razão Social do Cliente.
■ E-Mail:
● Campo obrigatório do tipo input que deverá receber caracteres alfa-numéricos
com no máximo 150 (cento e cinquenta) caracteres, o campo deverá possuir a
validação se o dado inserido é um e-mail;
● Tooltip: E-mail do Cliente.
■ Telefone:
● Campo obrigatório do tipo input que deverá receber caracteres numéricos com no
máximo 11 (onze) caracteres, o campo deverá possuir a máscara de telefone “(##)
#####-####;
● Tooltip: Telefone do Cliente.
■ Data de Cadastro:
● Campo que deverá retornar a data atual.
p. Abaixo da área principal, deverá ser apresentada a área de Informações Pessoais, esta
que deverá possuir os seguintes campos:
■ Tipo de Pessoa:
● Campo obrigatório do tipo combobox, que deverá retornar as opções Física e
Jurídica;
● Tooltip: Selecione o tipo de Pessoa.
■ CPF/CNPJ:
● Campo obrigatório do tipo input que deverá receber caracteres numéricos com no
máximo 14 (quatorze) caracteres, o campo deverá possuir a máscara de CPF
###.###.###-## para quando forem inseridos 11 (onze) caracteres e a máscara de
CNPJ "##.###.###/####-##" para quando forem inseridos mais caracteres;
● Tooltip: Insira o CPF ou o CNPJ do Cliente.
■ Inscrição Estadual:
● Campo obrigatório para o tipo de Pessoa Jurídica ou para ambos quando a
configuração "Inscrição estadual para Pessoa Física" estiver ativo, do tipo input que
deverá receber caracteres numéricos com no máximo 12 (doze) caracteres, o
campo deverá possuir a máscara ###.###.###-###;
● Tooltip: Inscrição Estadual do Cliente, selecionar Isento caso assim for.
■ Isento:
● Campo do tipo Checkbox, caso seja selecionado, a Inscrição Estadual estará
isenta. O campo Inscrição Estadual será bloqueado quando selecionado.
q. Os campos abaixo só deverão ser apresentados quando for selecionado o tipo de pessoa
Física:
■ Gênero:
● Campo obrigatório do tipo combobox, que deverá retornar as opções Feminino,
Masculino e Outro;
● Tooltip: Selecione o gênero do Cliente.
■ Data de Nascimento:
● Campo obrigatório do tipo date;
● Tooltip: Data de nascimento do Cliente.
r. A área de Situação do Cliente deverá possuir os seguintes campos:
■ Bloqueado:
● Campo do tipo checkbox;
● Tooltip: Bloqueio o acesso do Cliente na sua Loja;
● Regra: Quando um Cliente estiver selecionado como Bloqueado, o mesmo não
poderá acessar a Loja.
s. A área de Senha de Acesso deverá possuir os seguintes campos:
■ Tooltip: Cadastre a senha de acesso do seu Cliente;
■ Senha: Campo obrigatório do tipo input que deverá receber caracteres alfanuméricos
com no mínimo 8 (oito) caracteres e no máximo 15 (quinze) caracteres;
■ Confirmação de Senha: Campo obrigatório do tipo input que deverá receber
caracteres alfanuméricos com no mínimo 8 (oito) caracteres e no máximo 15 (quinze)
caracteres. Deverá ser validado se o valor inserido no campo de confirmação de
senha, é igual ao campo de senha. Caso os dados estejam diferentes, deverá ser
exibido a seguinte mensagem ao Usuário-Lojista “As senhas não conferem”.
t. Quando o Usuário-Lojista selecionar o botão "Adicionar Cliente", deverá ser validado se
todos os campos obrigatórios foram inseridos/selecionados;
u. Caso algum campo obrigatório não tenha sido inserido/selecionado, deverá ser
apresentada uma mensagem de obrigatoriedade de inserção/seleção do campo e o
Comprador não poderá ser adicionado;
v. Deverá ser validado se o e-mail inserido já está cadastrado na base de Compradores da
Loja, caso esteja, deverá ser apresentado um toast informando que o e-mail já está
vinculado a outro Comprador;
w. A mensagem a ser apresentada no toast deverá ser "Este e-mail já está cadastrado para
outro Cliente";
x. Deverá ser validado se o CPF/CNPJ inserido já está cadastrado na base de
Compradores da Loja, caso esteja, deverá ser apresentado um toast informando que o
CPF/CNPJ já está vinculado a outro Comprador;
y. A mensagem a ser apresentada no toast deverá ser "Este CPF/CNPJ já está cadastrado
para outro Cliente";
z. Quando o tipo o Comprador for do tipo Pessoa Jurídica ou quando a configuração
"Inscrição estadual para Pessoa Física" estiver ativada e o valor do campo Inscrição
Estadual for diferente de Isento, deverá ser validado se o valor inserido já está
cadastrado na base de Compradores da Loja, caso esteja, deverá ser apresentado um
toast informando que a Inscrição Estadual já está vinculada a outro Comprador;
aa. A mensagem a ser apresentada no toast deverá ser "Esta Inscrição Estadual já está
cadastrada para outro Cliente";
bb. Caso todos os campos obrigatórios tenham sido inseridos/selecionados, o
Comprador deverá ser criado e o Usuário-Lojista deverá ser redirecionado para a tela de
Clientes.
```
