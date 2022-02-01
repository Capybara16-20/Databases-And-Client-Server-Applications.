USE master
GO

CREATE DATABASE [������ ����]
ON
(NAME = TatooStudio_date, FILENAME = 'C:\Database\TatooStudio_date.mdf')
LOG ON
(NAME = TatooStudio_log, FILENAME = 'C:\Database\TatooStudio_log.ldf'); 
GO

USE [������ ����]
GO

CREATE TABLE �������������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
�������� nvarchar (100) NOT NULL,
[������ �� ��� ������] int NOT NULL)
GO

CREATE TABLE ������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
������������� int NOT NULL,
��� nvarchar(100) NOT NULL,
[���� ��������] date NOT NULL,
����� nvarchar (100),
������� nvarchar (16) NOT NULL,
CONSTRAINT FK_������_�������������
FOREIGN KEY (�������������) 
REFERENCES ������������� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE ������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
��� nvarchar(100) NOT NULL,
[���� ��������] date NOT NULL,
����� nvarchar (100),
������� nvarchar (16) NOT NULL)
GO

CREATE TABLE �����
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
�������� nvarchar (100) NOT NULL,
[����������� �������] real NOT NULL)
GO

CREATE TABLE ������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
������� nvarchar (100) NOT NULL,
[����������� �������] real NOT NULL)
GO

CREATE TABLE �����
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
����� int NOT NULL,
������ int NOT NULL,
[����� ���������] real NOT NULL,
CONSTRAINT FK_�����_�����
FOREIGN KEY (�����) 
REFERENCES ����� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_�����_������
FOREIGN KEY (������) 
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE [��� ������]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
�������� nvarchar (100) NOT NULL,
[��������� �����] real NOT NULL)
GO

CREATE TABLE [������ �� ����� ����������]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
������ int NOT NULL,
������ int NOT NULL,
����� int NOT NULL,
[��� ������] int NOT NULL,
���� date NOT NULL,
����� time NOT NULL,
[����� ������] real NOT NULL,
���� money NOT NULL,
CONSTRAINT FK_����������_������
FOREIGN KEY (������) 
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_����������_������
FOREIGN KEY (������) 
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_����������_�����
FOREIGN KEY (�����) 
REFERENCES ����� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_����������_���������
FOREIGN KEY ([��� ������]) 
REFERENCES [��� ������] (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE [����� ������]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
������ int NOT NULL,
������ int NOT NULL,
����� int NOT NULL,
���� money NOT NULL,
CONSTRAINT FK_�����������_������
FOREIGN KEY (������) 
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_�����������_������
FOREIGN KEY (������) 
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_�����������_�����
FOREIGN KEY (�����) 
REFERENCES ����� (ID))
GO

CREATE TABLE [��� ������]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
�������� nvarchar (100) NOT NULL,
��������� money NOT NULL)
GO

CREATE TABLE [������ �� ������]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
������ int NOT NULL,
������ int NOT NULL,
[��� ������] int NOT NULL,
���� date NOT NULL,
����� time NOT NULL,
���� money NOT NULL,
CONSTRAINT FK_������������_������
FOREIGN KEY (������) 
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_������������_������
FOREIGN KEY (������) 
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_������������_���������
FOREIGN KEY ([��� ������]) 
REFERENCES [��� ������] (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO