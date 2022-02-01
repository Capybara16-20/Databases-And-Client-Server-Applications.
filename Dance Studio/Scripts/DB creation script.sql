USE master
GO

CREATE DATABASE [Танцевальная студия]
ON
(NAME = Dance_date, FILENAME = 'C:\Database\Dance_date.mdf')
LOG ON
(NAME = Dance_log, FILENAME = 'C:\Database\Dance_log.ldf'); 
GO

USE [Танцевальная студия]
GO

CREATE TABLE Клиент
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
ФИО nvarchar(100) NOT NULL,
[Дата рождения] date NOT NULL,
Телефон nvarchar (16) NOT NULL)
GO

CREATE TABLE Стиль
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Название nvarchar(100) NOT NULL,
[Стоимость одного занятия] money NOT NULL)
GO

CREATE TABLE [Вид абонемента]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Стиль int NOT NULL,
[Количество тренировок] int NOT NULL,
Название nvarchar(100) NOT NULL,
CONSTRAINT FK_Вид_абонемента_Стиль
FOREIGN KEY (Стиль)
REFERENCES Стиль (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE Абонемент
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Клиент int NOT NULL,
[Вид абонемента] int NOT NULL,
[Количество индивидуальных занятий] int NOT NULL,
Стоимость money NOT NULL,
CONSTRAINT FK_Абонемент_Клиент
FOREIGN KEY (Клиент) 
REFERENCES Клиент (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Абонемент_Вид_абонемента
FOREIGN KEY ([Вид абонемента]) 
REFERENCES [Вид абонемента] (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE Группа
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Стиль int NOT NULL,
[Номер группы] int NOT NULL,
CONSTRAINT FK_Группа_Стиль
FOREIGN KEY (Стиль)
REFERENCES Стиль (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE [Абонементы групп]
(Абонемент int PRIMARY KEY NOT NULL,
Группа int NOT NULL,
CONSTRAINT FK_Абонементы_групп_Абонемент
FOREIGN KEY (Абонемент)
REFERENCES Абонемент (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Абонементы_групп_Группа
FOREIGN KEY (Группа)
REFERENCES Группа (ID)
ON DELETE NO ACTION
ON UPDATE NO ACTION)
GO

CREATE TABLE Зал
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
[Номер зала] int NOT NULL,
Этаж int NOT NULL)
GO

CREATE TABLE Преподаватель
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
ФИО nvarchar(100) NOT NULL,
[Дата рождения] date NOT NULL,
Телефон nvarchar (16) NOT NULL)
GO

CREATE TABLE Занятие
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Группа int NOT NULL,
Зал int NOT NULL DEFAULT 1,
Преподаватель int NOT NULL,
Стиль int NOT NULL,
Дата date NOT NULL,
Время time NOT NULL DEFAULT '12:00',
CONSTRAINT FK_Занятие_Группа
FOREIGN KEY (Группа)
REFERENCES Группа (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Занятие_Зал
FOREIGN KEY (Зал)
REFERENCES Зал (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Занятие_Преподаватель
FOREIGN KEY (Преподаватель)
REFERENCES Преподаватель (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Занятие_Стиль
FOREIGN KEY (Стиль)
REFERENCES Стиль (ID)
ON DELETE NO ACTION
ON UPDATE NO ACTION)
GO

CREATE TABLE [Индивидуальное занятие]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Абонемент int NOT NULL,
Преподаватель int NOT NULL DEFAULT 1,
Дата date NOT NULL,
Время time NOT NULL DEFAULT '12:00',
CONSTRAINT FK_Индивидуальное_занятие_Абонемент
FOREIGN KEY (Абонемент)
REFERENCES Абонемент (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Индивидуальное_занятие_Преподаватель
FOREIGN KEY (Преподаватель)
REFERENCES Преподаватель (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE Сертификат
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Преподаватель int NOT NULL,
Стиль int NOT NULL,
CONSTRAINT FK_Сертификат_Преподаватель
FOREIGN KEY (Преподаватель)
REFERENCES Преподаватель (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Сертификат_Стиль
FOREIGN KEY (Стиль)
REFERENCES Стиль (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO