



create schema Monster;
go

create table Monster.Monster
(
  MonsterId int not null identity(1,1) 
  ,GenderId int null  
  ,TitleId int null
  ,TypeId int not null
  ,Name nvarchar not null
  ,Picture nvarchar(256) null
  ,Active bit not null
);
go

create table Monster.MonsterType
(
  MonsterTypeId int not null identity(1,1) primary key
  ,TypeName nvarchar(250) not null
  ,Active bit not null
);
go
create table Monster.Gender
(
  GenderId int not null identity(1,1) primary key
  ,GenderName nvarchar(250) not null
  ,Active bit not null
);
go
create table Monster.Title
(
  TitleId int not null identity(1,1) primary key
  ,TitleName nvarchar(250) not null
  ,Active bit not null
);
go
--create table Monster.Genre
--(
--  GenreId int not null identity(1,1) primary key
--  ,GenreName nvarchar(250) not null
--  ,Active bit not null
--);
--go
/*create table Monster.MediaType
(
  MediaTypeId int not null identity(1,1) primary key
  ,MediaTypeName nvarchar(250) not null
  ,Active bit not null
);
--go
create table Monster.Media
(
  MediaId int not null identity(1,1) primary key
  ,GenreId int not null 
  ,MName nvarchar(250) not null
  ,MediaYear int null    
);*/
--go

alter table Monster.Monster
  add constraint pk_monster_monsterid primary key clustered (MonsterId);
  go

alter table Monster.Monster 
  add constraint fk_monster_genderid foreign key(GenderId) references Monster.Gender(GenderId);
  go
alter table Monster.Monster
  add constraint fk_monster_titleid foreign key(TitleId) references Monster.Title (Titleid);
  go
alter table Monster.Monster
  add constraint fk_monster_typeid foreign key(typeid) references Monster.MonsterType(monstertypeid);
  go
--alter table Monster.Media
--  add constraint fk_monster_genreid foreign key(GenreId) references Monster.Genre(GenreId);


create index ix_monster_name
    on Monster.Monster(Name);
go
--/*use master;
--go
--drop database MonsterDB;/*