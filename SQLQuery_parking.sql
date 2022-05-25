create database parking
use parking

create table promet(
id int identity(1,1) primary key,
datum_i_vreme datetime not null,
garaza int not null,
tablice nvarchar(10) not null,
ulaz_izlaz char not null 
)

create table garaza(
id int identity(1,1) primary key,
naziv nvarchar(20) not null,
adresa nvarchar(50) not null,
cena_po_satu int not null,
ukupno_mesta int not null,
zauzeto_mesta int not null default 0
)
drop table garaza

update garaza
set zauzeto_mesta = zauzeto_mesta + 1
where id = 1