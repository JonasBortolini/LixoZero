-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: lixo
-- ------------------------------------------------------
-- Server version	8.2.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ecoponto`
--

DROP TABLE IF EXISTS `ecoponto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ecoponto` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(255) NOT NULL,
  `Endereco` varchar(255) NOT NULL,
  `HorarioFuncionamento` varchar(255) NOT NULL,
  `Latitude` double NOT NULL,
  `Longitude` double NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ecoponto`
--

LOCK TABLES `ecoponto` WRITE;
/*!40000 ALTER TABLE `ecoponto` DISABLE KEYS */;
INSERT INTO `ecoponto` VALUES (1,'Bem Natural','Rua Sagitarius, 664 Apto 1 - Cruzeiro','Segunda a Sexta: 08h às 17h30',-29.1708685731935,-51.140157203087746),(2,'Escola de Filosofia Nova Acrópole Caxias','Rua Pinheiro Machado, 399','Segunda a Sexta: depois das 19h; Sábado: 09h às 11h30 e 13h30 às 17h30',-29.166207179111073,-51.16554944541688),(3,'Mônalis Odontologia','Rua Moreira César, 2695/301','Segunda a Sexta: 09h às 11h30 e 13h30 às 17h30',-29.166349831375136,-51.18574743192338),(4,'Quintal da Salsa','Rua Treze de Maio, 1159','Segunda a Sábado: 10h às 15h',-29.171183510008852,-51.167643031923404),(5,'Brinox','Rodovia RS 122, Km 80, 32503','Segunda a Sexta: 09h às 18h; Sábado: 10h às 16h50',-29.132477906170504,-51.19351460071775),(6,'Tem Design','Rua Henrique Fracasso, 559, térreo','Segunda a Sexta: 08h30 às 20h',-29.13783395759237,-51.176252014108385);
/*!40000 ALTER TABLE `ecoponto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ecoponto_residuo`
--

DROP TABLE IF EXISTS `ecoponto_residuo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ecoponto_residuo` (
  `EcoPontoId` int NOT NULL,
  `ResiduoId` int NOT NULL,
  PRIMARY KEY (`EcoPontoId`,`ResiduoId`),
  KEY `ResiduoId` (`ResiduoId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ecoponto_residuo`
--

LOCK TABLES `ecoponto_residuo` WRITE;
/*!40000 ALTER TABLE `ecoponto_residuo` DISABLE KEYS */;
INSERT INTO `ecoponto_residuo` VALUES (1,1),(1,4),(2,1),(2,2),(2,3),(2,4),(2,6),(3,1),(3,2),(3,3),(3,4),(3,6),(4,1),(4,3),(5,2),(5,6),(5,7),(5,8),(5,9),(5,10),(6,4);
/*!40000 ALTER TABLE `ecoponto_residuo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicacao`
--

DROP TABLE IF EXISTS `publicacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publicacao` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Titulo` varchar(255) NOT NULL,
  `Conteudo` text NOT NULL,
  `Imagem` varchar(255) DEFAULT NULL,
  `Data` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicacao`
--

LOCK TABLES `publicacao` WRITE;
/*!40000 ALTER TABLE `publicacao` DISABLE KEYS */;
INSERT INTO `publicacao` VALUES (1,'Comunidade realiza mutirão de limpeza em parque local','No último sábado, voluntários da comunidade se reuniram no Parque da Cidade para um mutirão de limpeza. Durante o evento, foram recolhidos mais de uma tonelada de resíduos, incluindo plásticos, vidros e papel. Essa iniciativa faz parte dos esforços da comunidade em promover práticas sustentáveis e alcançar a meta de Lixo Zero.','Imagem4.jpg','2024-05-30'),(2,'Novo projeto de reciclagem é lançado na cidade','A prefeitura da cidade lançou um novo projeto de reciclagem com o objetivo de incentivar a população a separar corretamente o lixo e contribuir para a preservação do meio ambiente. O projeto conta com a instalação de novos pontos de coleta seletiva e a realização de campanhas de conscientização.','Imagem5.jpg','2024-05-30'),(3,'Dicas para reduzir o consumo de plástico','O plástico é um dos principais poluentes do meio ambiente. Para ajudar a reduzir o consumo desse material, separamos algumas dicas simples que você pode seguir no seu dia a dia. Evite o uso de sacolas plásticas, opte por produtos com embalagens sustentáveis e recuse canudos plásticos. Pequenas atitudes fazem a diferença!','Imagem1.jpg','2024-05-30'),(4,'A importância da reciclagem de eletrônicos','Os eletrônicos contêm diversos materiais que podem ser reciclados, como metais e plásticos. No entanto, muitas pessoas ainda descartam esses produtos de forma inadequada, causando danos ao meio ambiente. Nessa publicação, vamos falar sobre a importância da reciclagem de eletrônicos e como você pode fazer o descarte correto.','Imagem2.jpg','2024-05-30'),(5,'Ações sustentáveis para o dia a dia','Pequenas ações sustentáveis podem fazer a diferença no nosso dia a dia. Nessa publicação, vamos compartilhar algumas dicas simples que você pode seguir para contribuir com a preservação do meio ambiente. Desde economizar água e energia até reciclar corretamente o lixo, todas as atitudes são importantes.','Imagem3.jpg','2024-05-30');
/*!40000 ALTER TABLE `publicacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicacao_residuo`
--

DROP TABLE IF EXISTS `publicacao_residuo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publicacao_residuo` (
  `PublicacaoId` int NOT NULL,
  `ResiduoId` int NOT NULL,
  PRIMARY KEY (`PublicacaoId`,`ResiduoId`),
  KEY `ResiduoId` (`ResiduoId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicacao_residuo`
--

LOCK TABLES `publicacao_residuo` WRITE;
/*!40000 ALTER TABLE `publicacao_residuo` DISABLE KEYS */;
INSERT INTO `publicacao_residuo` VALUES (1,5),(1,7),(2,1),(2,10),(3,5),(3,6),(3,7),(4,9),(4,10),(4,11),(5,2),(6,5),(6,7),(7,1),(7,10),(8,5),(8,6),(8,7),(9,9),(9,10),(9,11),(10,2);
/*!40000 ALTER TABLE `publicacao_residuo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `residuo`
--

DROP TABLE IF EXISTS `residuo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `residuo` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `residuo`
--

LOCK TABLES `residuo` WRITE;
/*!40000 ALTER TABLE `residuo` DISABLE KEYS */;
INSERT INTO `residuo` VALUES (1,'Esponjas de cozinha'),(2,'Lâminas de RAIO X'),(3,'Cápsulas de café'),(4,'Embalagens laminadas'),(5,'Papel branco'),(6,'Eletrônicos'),(7,'Tampinhas de garrafa'),(8,'Isopor'),(9,'Blister'),(10,'Pilhas e baterias'),(11,'Material de escritório');
/*!40000 ALTER TABLE `residuo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Login` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Senha` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'lixo'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-10 20:26:39
