CREATE DATABASE COMPUTADORA

CREATE TABLE COMPUTADORAA (
IDCOMPUTADORA INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
DESCRIPCION NVARCHAR (50) NOT NULL,
PRECIO MONEY NOT NULL,
FECHAFABRICACION DATETIME NOT NULL,
PRIMARY KEY (IDCOMPUTADORA),
);

insert into COMPUTADORAA values('compu1' ,'nuevo',10, '2022-02-01 14:00:00');
insert into COMPUTADORAA values('compu2' ,'nuevo' ,20, '2022-03-01 14:00:00');
insert into COMPUTADORAA values('compu3','nuevo' ,30, '2022-04-01 14:00:00');
insert into COMPUTADORAA values('compu4' ,'nuevo' ,40, '2022-08-01 14:00:00');
insert into COMPUTADORAA values('compu5' ,'viejo' ,50, '2020-02-01 14:00:00');
insert into COMPUTADORAA values('compu6' ,'nuevo' ,60, '2022-09-01 14:00:00');
insert into COMPUTADORAA values('compu7' ,'nuevo' ,70, '2022-01-01 14:00:00');
insert into COMPUTADORAA values('compu8' ,'viejo' ,80, '2022-02-07 14:00:00');
insert into COMPUTADORAA values('compu9','viejo' ,90, '2022-02-03 14:00:00');
insert into COMPUTADORAA values('compu10' ,'nuevo' ,100 , '2022-06-05 14:00:00');

SELECT*FROM COMPUTADORAA

