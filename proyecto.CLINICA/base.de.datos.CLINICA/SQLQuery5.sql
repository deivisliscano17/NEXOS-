CREATE DATABASE CLINICA

USE CLINICA

CREATE TABLE DOCTORES (
id_doctores INT PRIMARY KEY NOT NULL,
nombres VARCHAR (10) NOT NULL,
apellidos VARCHAR (10)NOT NULL,
especialidad VARCHAR (15)NOT NULL,
numero_credencial INT NOT NULL,
hospital_trabajo VARCHAR (15) NOT NULL
)

CREATE TABLE PACIENTES (
id_pacientes INT PRIMARY KEY NOT NULL,
id_doctores INT NOT NULL,
nombres VARCHAR (10) NOT NULL,
apellidos VARCHAR (10) NOT NULL,
genero CHAR (2) NOT NULL,
edad INT NOT NULL,
numero_seguro_social INT NOT NULL,
codigo_postal INT NOT NULL,
direccion VARCHAR (20) NOT NULL,
telefono_contacto INT NOT NULL
);