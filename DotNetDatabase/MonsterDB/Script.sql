﻿



create schema Monster;
go

create table Monster.Monster
(
  MonsterId int identity(1,1) not null
  ,GenderId int null  
  ,TitleId int null
  ,TypeId int not null
  ,Name nvarchar not null
  ,Picture nvarchar(256) null
  ,Active bit not null,
  CONSTRAINT [PK_Monster.Monster] PRIMARY KEY CLUSTERED ([MonsterId] ASC),
  CONSTRAINT [fk_Monster_GenderId] FOREIGN KEY(GenderId) REFERENCES Monster.Gender(GenderId),
  CONSTRAINT [fk_Monster_TitleId] FOREIGN KEY(TitleId) REFERENCES Monster.Title (TitleId),
  CONSTRAINT [fk_Monster_TypeId] FOREIGN KEY(TypeId) REFERENCES Monster.MonsterType(MonsterTypeId)
);
go

create table Monster.MonsterType
(
  MonsterTypeId int identity(1,1) not null
  ,TypeName nvarchar(250) not null
  ,Active bit not null,
  CONSTRAINT [PK_Monster.MonsterType] PRIMARY KEY CLUSTERED ([MonsterTypeId] ASC)
);
go
create table Monster.Gender
(
  GenderId int identity(1,1) not null
  ,GenderName nvarchar(250) not null
  ,Active bit not null,
  CONSTRAINT [PK_Monster.Gender] PRIMARY KEY CLUSTERED ([GenderId] ASC)
);
go
create table Monster.Title
(
  TitleId int identity(1,1) not null
  ,TitleName nvarchar(250) not null
  ,Active bit not null,
  CONSTRAINT [PK_Monster.Title] PRIMARY KEY CLUSTERED ([TitleId] ASC)
);
go

--create table Monster.Genre
--(
--  GenreId int identity(1,1) not null
--  ,GenreName nvarchar(250) not null
--  ,Active bit not null,
--  constraint pk_Monster_GenreId primary key clustered (GenreId)
--);
--go
--create table Monster.MediaType
--(
--  MediaTypeId int identity(1,1) not null
--  ,GenreId int not null 
--  ,MediaTypeName nvarchar(250) not null
--  ,Active bit not null,
--  constraint pk_Monster_MediaTypeId primary key clustered (MediaTypeId)
--);
--go
--create table Monster.Media
--(
--  MediaId int identity(1,1) not null
--  ,Title nvarchar(250) not null
--  ,ScareFactor int not null
--  ,MediaYear int null  
--  ,Active bit not null 
--  constraint pk_Monster_MediaId primary key clustered (MediaId) 
--);
--go

--alter table Monster.Monster
--  add constraint pk_Monster_MonsterId primary key clustered (MonsterId);
--  go

--alter table Monster.Monster 
--  add constraint fk_Monster_GenderId foreign key(GenderId) references Monster.Gender(GenderId);
--  go
--alter table Monster.Monster
--  add constraint fk_Monster_TitleId foreign key(TitleId) references Monster.Title (Titleid);
--  go
--alter table Monster.Monster
--  add constraint fk_Monster_TypeID foreign key(TypeID) references Monster.MonsterType(MonsterTypeID);
--  go
--alter table Monster.Genre
--  add constraint pk_Monster_GenreId primary key clustered (GenreId);
--go
--alter table Monster.MediaType
--  add constraint pk_Monster_MediaTypeId primary key clustered (MediaTypeId);
--go
--alter table Monster.Media
--  add constraint pk_Monster_GenreId primary key clustered (MediaId);
--go
--create index ix_Monster_name
--    on Monster.Monster(Name);
--go
--/*use master;
--go
--drop database MonsterDB;/*