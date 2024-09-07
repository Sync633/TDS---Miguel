#Criar o Banco de Dados
create database unijacupiranga;

#Apontar o Banco que iremos usar
use unijacupiranga;

#Criar tabela Alunos
create table alunos
(
id int auto_increment, 
nome varchar(50),
dt_nasc date,
rua varchar(100),
bairro varchar(30),
cidade varchar(30),
estado varchar(2),
dt_matricula date,
primary key (id)
);

#Criar tabela Professores
create table professores
(
id int auto_increment,
nome varchar(50),
dt_nasc date,
genero varchar(10),
rua varchar(100),
bairro varchar(30),
cidade varchar(30),
estado varchar(2),
dt_contratacao date, 
primary key (id)
);

#Criar tabela Disciplinas
create table disciplinas
(
id int auto_increment,
nome varchar(50),
carga_horaria varchar(8),
primary key (id)
);

#Criar tabela Cursos
create table cursos
(
id int auto_increment,
nome varchar(30),
duracao varchar(10),
dt_inicio date,
dt_fim date, 
primary key (id)
);

#Criar tabela alunoXtelefone
create table alunoXtelefone
(
id int auto_increment,
idAluno int,
numTelefone varchar(17),
primary key(id),
constraint fk_alunoXtelefone foreign key(idAluno) references alunos(id)
);

#Criar tabela alunoXemail
create table alunoXemail
(
id int auto_increment,
idAluno int,
email varchar(100),
primary key(id),
constraint fk_alunoXemail foreign key(idAluno) references alunos(id)
);

#Criar tabela professorXtelefone
create table professorXtelefone
(
id int auto_increment,
idProfessor int,
numTelefone varchar(17),
primary key(id),
constraint fk_professorXtelefone foreign key(idProfessor) references professores(id)
);

#Cria tabela professorXemail
create table professorXemail
(
id int auto_increment,
idProfessor int,
email varchar(100),
primary key(id),
constraint fk_professorXemail foreign key(idProfessor) references professores(id)
);

#Criar tabela alunoscursos
create table alunoXcurso
(
id int auto_increment,
idAluno int,
idCurso int,
primary key(id),
constraint fk_alunoXcurso foreign key(idAluno) references alunos(id),
constraint fk_cursoXaluno foreign key(idCurso) references cursos(id)
);

#Apagar Tabela
drop table alunoxcurso;

#Criar tabela cursoXdisciplina
create table cursosXdisciplinas
(
id int auto_increment,
idCurso int,
idDisciplina int,
primary key(id),
constraint fk_cursosXdisciplinas foreign key(idCurso) references cursos(id),
constraint fk_disciplinasXcursos foreign key(idDisciplina) references disciplinas(id)
);

#Criar tabela professorXdisciplina
create table professoresXdisciplinas
(
id int auto_increment,
idProfessor int,
idDisciplina int,
primary key(id),
constraint fk_professoresXdisciplinas foreign key(idProfessor) references professores(id),
constraint fk_disciplinasXprofessores foreign key(idDisciplina) references disciplinas(id)
);