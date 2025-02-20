CREATE DATABASE petLover;
USE petlover;

CREATE TABLE donos(
	idDono INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(60) NOT NULL,
	telefone VARCHAR(11),
	cpf CHAR(11) UNIQUE
);

CREATE TABLE pets(
	idPet INT PRIMARY KEY AUTO_INCREMENT,
	nomePet VARCHAR(60) NOT NULL,
	idade VARCHAR (3),
	especie VARCHAR(30),
	raca VARCHAR(20),
	fkIdDono INT NOT NULL,
	FOREIGN KEY (fkIdDono) REFERENCES donos(idDono)
);

CREATE TABLE servicos (
	idServico INT PRIMARY KEY AUTO_INCREMENT,
	descricaoServico VARCHAR(100),
	valorServico DECIMAL(10,2)
);

CREATE TABLE fornecedores (
idFornecedor INT PRIMARY KEY AUTO_INCREMENT,
nomeFornecedor VARCHAR(60) NOT NULL,
telefoneFornecedor VARCHAR(11),
cnpjFornecedor CHAR(14) UNIQUE
);

CREATE TABLE funcionarios (
idFuncionario INT PRIMARY KEY AUTO_INCREMENT,
nomeFuncionario VARCHAR(60) NOT NULL,
telefoneFuncionario VARCHAR(11),
cpfFuncionario CHAR(14) UNIQUE,
cargo VARCHAR(30)
);


CREATE TABLE petServico (
	idPetServico INT PRIMARY KEY AUTO_INCREMENT,
	valorTotal DECIMAL(10,2),
	dataServico DATE,
	formaPag VARCHAR(20),
	fkIdPet INT NOT NULL,
	FOREIGN KEY (fkIdPet) REFERENCES pets(idPet),
	fkIdServico INT NOT NULL,
	FOREIGN KEY (fkIdServico) REFERENCES servicos(idServico),
    fkIdFuncionario INT NOT NULL,
    FOREIGN KEY (fkIdFuncionario) REFERENCES Funcionarios(idFuncionario)
);

CREATE TABLE produtos (
	idProduto INT PRIMARY KEY AUTO_INCREMENT,
	descricao VARCHAR(100),
	marca VARCHAR(30),
	valorProduto DECIMAL (10,2),
    fkIdFornecedor INT NOT NULL,
    FOREIGN KEY (fkIdFornecedor) REFERENCES Fornecedores(IdFornecedor)
);

CREATE TABLE inventario (
	idInventario INT PRIMARY KEY AUTO_INCREMENT,
	quantidadeProduto INT NOT NULL,
    dataInventario DATE NOT NULL,
    fkIdProduto INT NOT NULL,
    FOREIGN KEY (fkIdProduto) REFERENCES produtos(idProduto)
    );

CREATE TABLE Vendas (
	idVenda INT PRIMARY KEY AUTO_INCREMENT,
    dataVenda DATE,
    formaPag VARCHAR(20),
	valorTotal DECIMAL(10,2),
	fkIdDono INT NOT NULL,
	FOREIGN KEY (fkIdDono) REFERENCES donos(idDono)
);
 
 CREATE TABLE itensVenda (
 idItensVenda INT PRIMARY KEY AUTO_INCREMENT,
 valorAtualItem DECIMAL (10,2),
 quantidade INT,
 fkIdProduto INT NOT NULL,
 FOREIGN KEY (fkIdProduto) REFERENCES produtos(idProduto),
 fkIdVenda INT NOT NULL,
 FOREIGN KEY (fkIdVenda) REFERENCES Vendas(idVenda)
 );
 
CREATE TABLE agendamentos (
idAgendadmento INT PRIMARY KEY AUTO_INCREMENT,
dataHora DATETIME NOT NULL,
fkIdPetServico INT NOT NULL,
FOREIGN KEY (fkIdPetServico) REFERENCES PetServico(idPetServico)
);




