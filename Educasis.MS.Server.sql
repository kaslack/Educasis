CREATE DATABASE educasis;

USE educasis;

--cod AS ('V-' + RIGHT('0000' + CONVERT(VARCHAR, id),(4))),

CREATE TABLE users(

	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	cod AS ('V-' + RIGHT('0000' + CONVERT(VARCHAR, id),(4))),
	users VARCHAR(50) NOT NULL,
	password VARCHAR(50) NOT NULL

);

CREATE TABLE contacts(

	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	cod AS ('V-' + RIGHT('0000' + CONVERT(VARCHAR, id),(4))),
	name VARCHAR(50) NOT NULL,
	mail VARCHAR(50) NOT NULL,
	phone VARCHAR(50) NOT NULL,
	message TEXT NOT NULL,
	contact VARCHAR(20) NOT NULL,
	date DATETIME2 NOT NULL

);

CREATE TABLE votes(

	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	cod AS ('V-' + RIGHT('0000' + CONVERT(VARCHAR, id),(4))),
	appreciation INT NOT NULL

)

CREATE TABLE ip(

	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	cod AS ('V-' + RIGHT('0000' + CONVERT(VARCHAR, id),(4))),
	ip varchar(20) NOT NULL

);