create table pre_agendamento(
	nome VARCHAR(100) NOT NULL,
	telefone VARCHAR(15) NOT NULL,
	data_consulta DATE NOT NULL,
	animal VARCHAR(50) NOT NULL,
	necessidade VARCHAR(255) NOT NULL,
	PRIMARY KEY(nome, telefone)
)