USE master
GO

CREATE DATABASE [������������ ������]
ON
(NAME = Dance_date, FILENAME = 'C:\Database\Dance_date.mdf')
LOG ON
(NAME = Dance_log, FILENAME = 'C:\Database\Dance_log.ldf'); 
GO

USE [������������ ������]
GO

CREATE TABLE ������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
��� nvarchar(100) NOT NULL,
[���� ��������] date NOT NULL,
������� nvarchar (16) NOT NULL)
GO

CREATE TABLE �����
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
�������� nvarchar(100) NOT NULL,
[��������� ������ �������] money NOT NULL)
GO

CREATE TABLE [��� ����������]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
����� int NOT NULL,
[���������� ����������] int NOT NULL,
�������� nvarchar(100) NOT NULL,
CONSTRAINT FK_���_����������_�����
FOREIGN KEY (�����)
REFERENCES ����� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE ���������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
������ int NOT NULL,
[��� ����������] int NOT NULL,
[���������� �������������� �������] int NOT NULL,
��������� money NOT NULL,
CONSTRAINT FK_���������_������
FOREIGN KEY (������) 
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_���������_���_����������
FOREIGN KEY ([��� ����������]) 
REFERENCES [��� ����������] (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE ������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
����� int NOT NULL,
[����� ������] int NOT NULL,
CONSTRAINT FK_������_�����
FOREIGN KEY (�����)
REFERENCES ����� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE [���������� �����]
(��������� int PRIMARY KEY NOT NULL,
������ int NOT NULL,
CONSTRAINT FK_����������_�����_���������
FOREIGN KEY (���������)
REFERENCES ��������� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_����������_�����_������
FOREIGN KEY (������)
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE NO ACTION)
GO

CREATE TABLE ���
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
[����� ����] int NOT NULL,
���� int NOT NULL)
GO

CREATE TABLE �������������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
��� nvarchar(100) NOT NULL,
[���� ��������] date NOT NULL,
������� nvarchar (16) NOT NULL)
GO

CREATE TABLE �������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
������ int NOT NULL,
��� int NOT NULL DEFAULT 1,
������������� int NOT NULL,
����� int NOT NULL,
���� date NOT NULL,
����� time NOT NULL DEFAULT '12:00',
CONSTRAINT FK_�������_������
FOREIGN KEY (������)
REFERENCES ������ (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_�������_���
FOREIGN KEY (���)
REFERENCES ��� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_�������_�������������
FOREIGN KEY (�������������)
REFERENCES ������������� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_�������_�����
FOREIGN KEY (�����)
REFERENCES ����� (ID)
ON DELETE NO ACTION
ON UPDATE NO ACTION)
GO

CREATE TABLE [�������������� �������]
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
��������� int NOT NULL,
������������� int NOT NULL DEFAULT 1,
���� date NOT NULL,
����� time NOT NULL DEFAULT '12:00',
CONSTRAINT FK_��������������_�������_���������
FOREIGN KEY (���������)
REFERENCES ��������� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_��������������_�������_�������������
FOREIGN KEY (�������������)
REFERENCES ������������� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO

CREATE TABLE ����������
(ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
������������� int NOT NULL,
����� int NOT NULL,
CONSTRAINT FK_����������_�������������
FOREIGN KEY (�������������)
REFERENCES ������������� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE,
CONSTRAINT FK_����������_�����
FOREIGN KEY (�����)
REFERENCES ����� (ID)
ON DELETE NO ACTION
ON UPDATE CASCADE)
GO