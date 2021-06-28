--CREANDO BASE DE DATOS
CREATE DATABASE PROJECT_BD_POO;
USE PROJECT_BD_POO;
SET LANGUAGE 'us_english';

--Creando tablas 
CREATE TABLE MANAGER (
		id_manager INT PRIMARY KEY IDENTITY NOT NULL,
		id_type_employee INT NOT NULL,
		manager_name VARCHAR(50) NOT NULL, 
		manager_address VARCHAR(100) NOT NULL, 
		institutional_email VARCHAR(50) NOT NULL, 
		user_m VARCHAR(50) NOT NULL, 
		psw VARCHAR(50) NOT NULL 
);

CREATE TABLE TYPE_EMPLOYEE (
		id_type_employee INT PRIMARY KEY IDENTITY NOT NULL, 
		type_employee VARCHAR(50) NOT NULL 
);

CREATE TABLE CABIN(
		id_cabin INT PRIMARY KEY IDENTITY NOT NULL, 
		id_manager INT NOT NULL,
		cabin_address VARCHAR(100) NOT NULL, 
		cabin_email VARCHAR(50) NOT NULL, 
		phoneNumber VARCHAR(50) NOT NULL
);

CREATE TABLE SESSION_U(
		id_session INT PRIMARY KEY IDENTITY NOT NULL,
		id_manager INT NOT NULL, 
		id_cabin INT NOT NULL,
		session_date DATETIME NOT NULL
);

CREATE TABLE CITIZEN_FORM(
		dui_c VARCHAR(10) PRIMARY KEY  NOT NULL,
		vaccine_date DATETIME NULL,
		citizen_address VARCHAR(100) NOT NULL, 
		citizen_name VARCHAR(50) NOT NULL, 
		telephone VARCHAR(9) NOT NULL, 
		citizen_email VARCHAR(50) NULL,
		id_institution INT NOT NULL,
		priority_group BIT NOT NULL, 
);

CREATE TABLE SIDE_EFFECTS(
		id_side_effects INT PRIMARY KEY IDENTITY  NOT NULL,
		dui_c VARCHAR(10) NOT NULL, 
		side_effects_name VARCHAR(400) NULL
);

CREATE TABLE CHRONIC_DISEASE(
		id_cronic_disease INT PRIMARY KEY IDENTITY  NOT NULL,
		dui_c VARCHAR(10) NOT NULL, 
		disease_name VARCHAR(75) NULL
);

CREATE TABLE INSTITUTION (
		id_institution INT PRIMARY KEY  IDENTITY NOT NULL, 
		institution_name VARCHAR(50) NOT NULL 
);

CREATE TABLE APPOINTMENT(
		id_appontiment INT PRIMARY KEY IDENTITY NOT NULL,
		id_cabin INT NOT NULL,
		dui_c VARCHAR(10) NOT NULL, 
		appointment_date DATETIME NOT NULL,
		appointment_address VARCHAR(100) NOT NULL,
		waiting_time VARCHAR(30) NULL
);

--Llaves foraneas 

--Llave Foranea de MANAGER
ALTER TABLE MANAGER ADD FOREIGN KEY (id_type_employee) REFERENCES TYPE_EMPLOYEE (id_type_employee);

--Llave foranea de CABIN
ALTER TABLE CABIN ADD FOREIGN KEY (id_manager) REFERENCES MANAGER (id_manager);

--Llave foranea de SESSION_U
ALTER TABLE SESSION_U ADD FOREIGN KEY (id_manager) REFERENCES MANAGER (id_manager);
ALTER TABLE SESSION_U ADD FOREIGN KEY (id_cabin) REFERENCES CABIN (id_cabin);

--Llave foranea de CITIZEN_FORM
ALTER TABLE CITIZEN_FORM ADD FOREIGN KEY (id_institution) REFERENCES INSTITUTION (id_institution);

--Llave foranea de SIDE_EFFECTS
ALTER TABLE SIDE_EFFECTS ADD FOREIGN KEY (dui_c) REFERENCES CITIZEN_FORM (dui_c);

--Llave foranea de CHRONIC_DISEASE
ALTER TABLE CHRONIC_DISEASE ADD FOREIGN KEY (dui_c) REFERENCES CITIZEN_FORM (dui_c);

--Llave foranea de APPOINTMENT
ALTER TABLE APPOINTMENT ADD FOREIGN KEY (dui_c) REFERENCES CITIZEN_FORM (dui_c);
ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_cabin) REFERENCES CABIN (id_cabin);

/*
Datos ejemplo para y orden de inserción para un correcto  funcionamiento del programa
(debe realizarse estas inserciones antes de correr el programa

Pasos
--1) Insertar tipos de empleado
INSERT INTO TYPE_EMPLOYEE values('Doctor');
INSERT INTO TYPE_EMPLOYEE values('Doctora');
INSERT INTO TYPE_EMPLOYEE values('Enfermero');
INSERT INTO TYPE_EMPLOYEE values('Enfermera');
INSERT INTO TYPE_EMPLOYEE values('Auxiliar');

--2) Insertar managers
INSERT INTO MANAGER values(1,'Mateo Jesus de Leon', 'Colonia el milagro, Desvio de opico', 'mat2839@org.sv', 'mj5534', '22821');
INSERT INTO MANAGER values(3,'Jose Manuel Cartagena', 'Colonia el matazano, Soyapango', 'manuel_cat@org.sv', 'm2222', '33589');
INSERT INTO MANAGER values(1,'Marcos Antonio Fernandez', 'Colonia Buenos Aires, Soyapango', 'ma.anto_12@org.sv', 'ant587', '524163');
INSERT INTO MANAGER values(4,'Fatima Alejandra Carvajal', 'Colonia Belen, Lourdes Colon', 'fati.carvajal@org.sv', 'facvj20', 'jkl58');
INSERT INTO MANAGER values(5,'Jose Angel Escobar', 'Cuidad Armenia, La libertad', 'jangel@org.sv', 'jjanl', 'k2209');

--3) Insertar instituciones
INSERT INTO INSTITUTION VALUES('Nínguno');
INSERT INTO INSTITUTION VALUES('Educación');
INSERT INTO INSTITUTION VALUES('Salud');
INSERT INTO INSTITUTION VALUES('Policía Nacional Civil');
INSERT INTO INSTITUTION VALUES('Gobierno');
INSERT INTO INSTITUTION VALUES('Fuerza Armada');
INSERT INTO INSTITUTION VALUES('Periodismo');
INSERT INTO INSTITUTION VALUES('Cuerpos de socorro');
INSERT INTO INSTITUTION VALUES('Personal de fronteras');
INSERT INTO INSTITUTION VALUES('Centros penales');

--4) Insertar las cabinas
INSERT INTO CABIN VALUES (1, 'Unidad de Salud de Lourdes, Colon','cabina1@org.sv','2364-8596');
INSERT INTO CABIN VALUES (2, 'Centro Médico Zapotitán, Cuidad Arce','cabina2@org.sv','2385-8596');
INSERT INTO CABIN VALUES (3, 'Centro Médico San Antonio, Soyapango','cabina3@org.sv','2312-5874');
INSERT INTO CABIN VALUES (4, 'Centro Medico de Santa Ana, 6a Avenida Sur, Santa Ana','cabina4@org.sv','2258-5874');
INSERT INTO CABIN VALUES (5, 'Hospital Centro Medico Sonsonate, Barrio El Pilar, 5A Avenida Norte, Sonsonate','cabina5@org.sv','2354-8596');
*/