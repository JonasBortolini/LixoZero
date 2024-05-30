CREATE TABLE EcoPonto (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Endereco VARCHAR(255) NOT NULL,
    HorarioFuncionamento VARCHAR(255) NOT NULL,
    Latitude DOUBLE NOT NULL,
    Longitude DOUBLE NOT NULL
);

CREATE TABLE Residuo (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Tipo VARCHAR(255) NOT NULL
);

CREATE TABLE Publicacao (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Titulo VARCHAR(255) NOT NULL,
    Conteudo TEXT NOT NULL,
    Imagem VARCHAR(255),
    Data VARCHAR(255) NOT NULL
);

CREATE TABLE Usuario (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Login VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Senha VARCHAR(255) NOT NULL
);

CREATE TABLE EcoPonto_Residuo (
    EcoPontoId INT,
    ResiduoId INT,
    PRIMARY KEY (EcoPontoId, ResiduoId),
    FOREIGN KEY (EcoPontoId) REFERENCES EcoPonto(Id),
    FOREIGN KEY (ResiduoId) REFERENCES Residuo(Id)
);

CREATE TABLE Publicacao_Residuo (
    PublicacaoId INT,
    ResiduoId INT,
    PRIMARY KEY (PublicacaoId, ResiduoId),
    FOREIGN KEY (PublicacaoId) REFERENCES Publicacao(Id),
    FOREIGN KEY (ResiduoId) REFERENCES Residuo(Id)
);
