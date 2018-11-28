use master
drop database EtecBanco
create database EtecBanco
go
use EtecBanco
go

create table Aluno(
	--idAluno, rgAluno, cpfAluno, dsEndereco, nmAluno, foneAluno, curso
	idAluno int primary key identity(1,1),
	rgAluno varchar(30),
	cpfAluno varchar(30),
	dsEndereco varchar(255),
	nmAluno varchar(255),
	foneAluno varchar(25),
	curso varchar(50)
)

create table Curso (
	idCurso int primary key identity(1,1),
	nmCurso varchar (255)
)

insert into Curso values ('Informática'), ('Desenvolvimento de Sistemas'), ('Administração'), ('Recursos Humanos'), ('Serviços Jurídicos')

insert into Aluno values ('38.120.158-X','246.146.411-04','Rua do Francisco Jovem, 50C','Ronaldo da Cruz','(11)2577-8899','Informática')
insert into Aluno values ('72.400.212-2','876.465.797-00','Rua Antunes Medeiros, 420','Fábio Santana de Melo','(11)2177-8892','Administração de Empresas')

select*from Aluno
select*from Curso