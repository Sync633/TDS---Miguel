create database empresa_teste;

use empresa_teste; 

create table departamento
(
id int auto_increment primary key,
descricao varchar(100) not null
);

create table funcionario
(
id int auto_increment primary key,
nome varchar(255) not null,
dtnascimento date,
departamento_id int not null,
foreign key (departamento_id) references departamento(id)
);

insert into departamento (descricao) values ("recursos_humanos");
insert into departamento (descricao) values ("tecnologia_informação");
insert into departamento (descricao) values ("financeiro");
insert into departamento (descricao) values ("rural");

insert into funcionario (nome, dtnascimento, departamento_id) values ("Miguel Santos Pereira", "2006-12-02", 2);


select * from funcionario;

delete from departamento where id=1;

