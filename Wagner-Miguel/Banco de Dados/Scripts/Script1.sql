create database teste1;
use teste1;
create table pessoas 
(
codigo int auto_increment,
nome varchar(50) ,
primary key(codigo)
);

insert into pessoas(nome) values ("Miguel");
select * from pessoas;