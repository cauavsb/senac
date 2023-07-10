-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 25-Jun-2023 às 23:02
-- Versão do servidor: 10.4.28-MariaDB
-- versão do PHP: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `senac`
--

--
-- Extraindo dados da tabela `pacote`
--

INSERT INTO `pacote` (`id`, `nome`, `origem`, `destino`, `atrativos`, `saida`, `retorno`, `usuario`) VALUES
(19, 'Europa', 'Recife', 'Madrid', 'Viagem internacional', '2023-07-01 00:00:00', '2023-12-31 00:00:00', 1),
(20, 'Sul do país', 'Alagoas', 'Rio Grande do Sul', 'Inverno ', '2023-08-13 00:00:00', '2023-08-30 00:00:00', 2),
(21, 'Verão no Nordeste', 'Rio de Janeiro', 'Fernando de Noronha', 'Praias', '2024-01-10 00:00:00', '2024-01-30 00:00:00', 3);

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id`, `nome`, `login`, `senha`, `data_nascimento`) VALUES
(1, 'Cauã Vinícius', 'CauaViniXL', '123', '2004-01-26'),
(2, 'Ana Vitória', 'AnaVitoriaXL', '456', '2004-12-25'),
(3, 'Sinara Maysa', 'SinaraMaysaXL', '789', '1987-04-30');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
