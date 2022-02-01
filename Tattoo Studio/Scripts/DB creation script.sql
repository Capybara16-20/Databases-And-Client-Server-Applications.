USE master
GO

CREATE DATABASE [Студия тату]
ON
(NAME = TatooStudio_date, FILENAME = 'C:\Database\TatooStudio_date.mdf')
LOG ON
(NAME = TatooStudio_log, FILENAME = 'C:\Database\TatooStudio_log.ldf'); 
GO

USE [Студия тату]
GO

CREATE TABLE Специальность
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Название nvarchar (100) NOT NULL,
[Оплата за час работы] int NOT NULL)
GO

CREATE TABLE Мастер
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Специальность int NOT NULL,
ФИО nvarchar(100) NOT NULL,
[Дата рождения] date NOT NULL,
Адрес nvarchar (100),
Телефон nvarchar (16) NOT NULL,
CONSTRAINT FK_Мастер_Специальность
FOREIGN KEY (Специальность) 
REFERENCES Специальность (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE Клиент
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
ФИО nvarchar(100) NOT NULL,
[Дата рождения] date NOT NULL,
Адрес nvarchar (100),
Телефон nvarchar (16) NOT NULL)
GO

CREATE TABLE Стиль
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Название nvarchar (100) NOT NULL,
[Коэффициент времени] real NOT NULL)
GO

CREATE TABLE Размер
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Размеры nvarchar (100) NOT NULL,
[Коэффициент времени] real NOT NULL)
GO

CREATE TABLE Эскиз
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Стиль int NOT NULL,
Размер int NOT NULL,
[Время нанесения] real NOT NULL,
CONSTRAINT FK_Эскиз_Стиль
FOREIGN KEY (Стиль) 
REFERENCES Стиль (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Эскиз_Размер
FOREIGN KEY (Размер) 
REFERENCES Размер (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE [Вид работы]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Название nvarchar (100) NOT NULL,
[Начальное время] real NOT NULL)
GO

CREATE TABLE [Запись на сеанс татуировки]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Мастер int NOT NULL,
Клиент int NOT NULL,
Эскиз int NOT NULL,
[Вид работы] int NOT NULL,
Дата date NOT NULL,
Время time NOT NULL,
[Время работы] real NOT NULL,
Цена money NOT NULL,
CONSTRAINT FK_Записьтату_Мастер
FOREIGN KEY (Мастер) 
REFERENCES Мастер (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Записьтату_Клиент
FOREIGN KEY (Клиент) 
REFERENCES Клиент (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Записьтату_Эскиз
FOREIGN KEY (Эскиз) 
REFERENCES Эскиз (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Записьтату_Видработы
FOREIGN KEY ([Вид работы]) 
REFERENCES [Вид работы] (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE [Заказ эскиза]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Мастер int NOT NULL,
Клиент int NOT NULL,
Эскиз int NOT NULL,
Цена money NOT NULL,
CONSTRAINT FK_Заказэскиза_Мастер
FOREIGN KEY (Мастер) 
REFERENCES Мастер (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Заказэскиза_Клиент
FOREIGN KEY (Клиент) 
REFERENCES Клиент (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Заказэскиза_Эскиз
FOREIGN KEY (Эскиз) 
REFERENCES Эскиз (ID))
GO

CREATE TABLE [Вид услуги]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Название nvarchar (100) NOT NULL,
Стоимость money NOT NULL)
GO

CREATE TABLE [Запись на услугу]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Мастер int NOT NULL,
Клиент int NOT NULL,
[Вид услуги] int NOT NULL,
Дата date NOT NULL,
Время time NOT NULL,
Цена money NOT NULL,
CONSTRAINT FK_Записьуслуга_Мастер
FOREIGN KEY (Мастер) 
REFERENCES Мастер (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Записьуслуга_Клиент
FOREIGN KEY (Клиент) 
REFERENCES Клиент (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_Записьуслуга_Видуслуги
FOREIGN KEY ([Вид услуги]) 
REFERENCES [Вид услуги] (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO