create database projTCM_clinica


create table agenda(
cod_agenda int primary key identity,
FOREIGN KEY (cod_agenda) REFERENCES cadastro_consulta(cod_consulta),
pesquisa_agenda varchar(50)
)

create table cadastro_consulta(
cod_consulta int primary key identity,
FOREIGN KEY (cod_consulta) REFERENCES cadastro_paciente(cod_paciente),
FOREIGN KEY (cod_consulta) REFERENCES cadastro_medico(cod_medico),
Data_cons varchar(9),
Hora_cons varchar(6),
Dia_cons varchar(40),
)

create table exame(
cod_exame int primary key identity,
FOREIGN KEY (cod_exame) REFERENCES cadastro_paciente(cod_paciente),
nome_exame varchar(50),
data_exame varchar(9),
nome_pac varchar(50)
)

create table cadastro_paciente (
cod_paciente int primary key identity,
cod_agenda int,
prontuario_pac int,
nome_pac varchar(50) not null,
nasc_pac datetime,
idade_pac varchar(3),
cpf_pac varchar(12) unique not null, 
rg_pac varchar(10) unique,
etnia_pac varchar(10),
sexo_pac char,
rua_pac varchar(40),
bairro_pac varchar(30),
numero_rua_pac varchar (10),
cidade_pac varchar(40),
telefone_pac int,
celular_pac int,
email_pac varchar(40),
Pai_pac varchar(50),
Mae_pac varchar(50),
responsavel_pac varchar(50),
)

create table cadastro_medico(
cod_medico int primary key identity,
cod_agenda int,
nome_Medico varchar(50) not null,
nasc_Medico varchar(9),
idade_Medico varchar(3),
cpf_Medico varchar(20) not null unique, 
rg_Medico varchar(20) not null unique,
especialidade_Medico varchar(10) not null,
crm_Medico varchar(40) not null unique,
rua_Medico varchar(50),
numRua_Medico varchar(50),
complemento_Medico varchar(20),
cep_Medico varchar(9),
Naturalidade_Medico varchar(20),
uf_Medico varchar(2),
cidade_Medico varchar(30),
telefone_Medico int,
celular_Medico int,
convenio_Medico varchar(20),
matricula_Medico varchar(20),
horario_Medico varchar(30),
dias_Medico varchar (50),
email_Medico varchar(40)
)

create table cadastro_funcionario(
cod_func int primary key identity,
cod_agenda int,
nome_func varchar(50) not null,
Rua_func varchar(50),
Num_rua_func varchar(10),
Bairro_func varchar(20),
Cidade_func varchar(30),
Uf_func varchar(2),
DtNasc_func varchar(9),
Cargo_func varchar(30),
Hrexp_func varchar(6),
Tel_func int,
Cel_func int,
email_func varchar(40),
Matricula_func varchar(20)
)