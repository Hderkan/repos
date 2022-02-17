--create database sRehber
use sRehber
create table tblKisiler
(
ID INT IDENTITY(1,1),
Ad varchar(20) not null,
Soyad varchar(20) not null,
Cinsiyet char not null,
Telefon Nchar(11) not null,
primary key(ID)
)
INSERT INTO tblKisiler
values
	('Haluk','Levent','E','05554325566'),
	('Seren','Günac','K','05552325566'),
	('Kemal','Kalbur','E','05454325566'),
	('Saide','Kül','K','05554325567'),
	('Mahir','Çakmak','E','05554225566'),
	('Canan','Solak','K','05554325766')