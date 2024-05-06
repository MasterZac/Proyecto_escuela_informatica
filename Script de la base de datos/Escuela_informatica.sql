
create database Escuela_informatica;

use Escuela_informatica;

create table Grupo
(
   Numero_grupo char(10) primary key, 
   Nombre varchar(100) not null,
   Numero_componentes int default 0 not null,
   Estatus varchar(50) not null 
)

create table TFC
(
  Numero_orden char(10) primary key,
  Fecha_comienzo datetime not null,
  Tema varchar(100) not null,
  Estatus varchar(50) not null
)

create table Profesor 
(
  CI varchar(5) primary key,
  Nombre varchar(100) not null,
  Domicilio varchar(100) not null,
  Estatus varchar(50) not null
)

create table tribunal
(
  Numero_tribunal char(5) primary key,
  Lugar_examen varchar(100) not null,
  Numero_componentes int default 0 not null,
  Estatus varchar(50) not null,
)

create table Alumno 
(
  Matricula char(10) primary key,
  CI varchar(5) not null,
  Nombre varchar(100) not null,
  Numero_grupo char(10) not null,
  CI_profesor varchar(5) not null,
  Numero_orden_tfc char(10) not null,
  Estatus varchar(50) not null,
  constraint fkGrupo foreign key (Numero_grupo) references Grupo (Numero_grupo),
  constraint fkProfesor foreign key (CI_profesor) references Profesor (CI),
  constraint fkTFC foreign key (Numero_orden_tfc) references TFC (Numero_orden)
)

create table Ayuda
(
  Matricula_alumno char(10) not null,
  CI_profesor varchar(5) not null,
  constraint fkAlumno foreign key (Matricula_alumno) references Alumno (Matricula),
  constraint fkProfesor_ayuda foreign key (CI_profesor) references Profesor (CI)
)

create table Se_conforma 
(
  Numero_tribunal char(5) not null,
  CI_profesor varchar(5) not null,
  constraint fkClave_tribunal foreign key (Numero_tribunal) references Tribunal (Numero_tribunal),
  constraint fkClave_profesor foreign key (CI_profesor) references Profesor (CI)
)

create table Examina
(
  Num_Tribunal char(5) not null,
  Matricula_alumno char(10) not null,
  Numero_orden_tfc char(10) not null,
  constraint fkExamina_Tribunal foreign key (Num_tribunal) references tribunal (Numero_tribunal),
  constraint fkExamina_alumno foreign key (Matricula_alumno) references Alumno (Matricula),
  constraint fkExamina_Orden_tfc foreign key (Numero_orden_tfc) references TFC (Numero_orden)
)

/*Procedimientos almacenados de Alumno*/
create procedure AddAlumno
@Matricula char(10), @CI varchar(5) ,@Nombre varchar(100), @Numero_grupo char(10), @CI_profesor varchar(5), @Numero_orden char(10)
as
begin
  declare @Estatus varchar(50) = 'Activo';
  insert into Alumno values (@Matricula, @CI, @Nombre, @Numero_grupo, @CI_profesor, @Numero_orden, @Estatus)
end
go

create procedure DeleteAlumno
@Matricula char(10), @Estatus varchar(50)
as
begin
  update Alumno set Estatus = @Estatus Where Matricula = @Matricula
end
go

create procedure UpdateAlumno
@Matricula char(10), @CI varchar(5) ,@Nombre varchar(100), @Numero_grupo char(10), @CI_profesor varchar(5), @Numero_orden char(10)
as
begin
  update Alumno set Nombre = @Nombre, Numero_grupo = @Numero_grupo, CI_profesor = @CI_profesor, Numero_orden_tfc = @Numero_orden Where Matricula = @Matricula
end
go


/*Procedimientos almacenados de Grupo*/
create procedure AddGrupo
@Numero_grupo char(10), @Nombre varchar(100), @Numero_componentes int
as
begin
Declare @estatus varchar(50) = 'Activo';
insert into Grupo values (@Numero_grupo, @Nombre, @Numero_componentes, @estatus)
end
go

create procedure DeleteGrupo
@Numero_grupo char(10), @Estatus varchar(50)
as
begin
update grupo set Estatus = @Estatus Where Numero_grupo = @Numero_grupo
end
go

create procedure UpdateGrupo
@Numero_grupo char(10), @Nombre varchar(100), @Numero_componentes int
as
begin
update Grupo set Nombre = @Nombre, Numero_componentes = @Numero_componentes Where Numero_grupo = @Numero_grupo
end
go

/*Procedimientos almacenados de tribunal*/

create procedure AddTribunal
@Numero_tribunal char(5), @Lugar_examen varchar(100), @Numero_componentes int
as
begin
declare @estatus varchar(50) = 'Activo';
insert into tribunal values (@Numero_tribunal, @Lugar_examen, @Numero_componentes, @estatus)
end
go

create procedure DeleteTribunal
@Numero_tribunal char(5), @Estatus varchar(50)
as
begin
update tribunal set Estatus = @Estatus Where Numero_tribunal = @Numero_tribunal
end
go

create procedure UpdateTribunal
@Numero_tribunal char(5), @Lugar_examen varchar(100), @Numero_componentes int
as
begin
update tribunal set Lugar_examen = @Lugar_examen, Numero_componentes = @Numero_componentes Where Numero_tribunal = @Numero_tribunal
end
go

/*Procedimientos almacenados de TFC*/

create procedure AddTFC
@Numero_orden char(10), @Fecha_comienzo date, @Tema varchar(100)
as
begin
declare @estatus varchar(50) = 'Activo';
insert into TFC values (@Numero_orden, @Fecha_comienzo, @Tema, @estatus)
end
go

create procedure DeleteTFC
@Numero_orden char(10), @Estatus varchar(50)
as
begin
update TFC set Estatus = @Estatus  Where Numero_orden = @Numero_orden
end
go

create procedure UpdateTFC
@Numero_orden char(10), @Fecha_comienzo date, @Tema varchar(100)
as
begin
update TFC set Fecha_comienzo = @Fecha_comienzo, Tema = @Tema Where Numero_orden = @Numero_orden
end
go

/*Procedimientos almacenados de profesor*/
create procedure AddProfesor
@CI varchar(5), @Nombre varchar(100), @Domicilio varchar(100)
as
  begin
  declare @Estatus varchar(50) = 'Activo';
  insert into Profesor values(@CI, @Nombre, @Domicilio, @Estatus)
  end
go

create procedure DeleteProfesor
@CI varchar(5), @Estatus varchar(50)
as
  begin
  update Profesor set Estatus = @Estatus Where CI = @CI
  end
go

create procedure UpdateProfesor
@CI varchar(5), @Nombre varchar(100), @Domicilio varchar(100)
as
  begin
  update profesor set Nombre = @Nombre, Domicilio = @Domicilio Where CI = @CI
  end
go



/*PROCEDIMIENTOS ALMACENADOS DE AYUDA*/

create procedure AddAyuda
@Matricula_alumno char(10), @CI_profesor varchar(5)
as
  begin
  insert into Ayuda values(@Matricula_alumno, @CI_profesor)
  end
go

create procedure UpdateAyuda
@Matricula_alumno char(10), @CI_profesor varchar(5)
as
begin
update Ayuda set Matricula_alumno = @Matricula_alumno, CI_profesor = @CI_profesor Where Matricula_alumno = @Matricula_alumno and CI_profesor = @CI_profesor
end
go

/*Procedimientos almacenados de la tabla Se conforma*/
create procedure AddSeConforma
@Numero_tribunal char(5), @CI_profesor varchar(5)
as
  begin
  insert into Se_conforma values(@Numero_tribunal, @CI_profesor)
  end
go

/*Procedimientos almacenados para la tabla Examina*/

create procedure AddExamina
@Num_tribunal char(5), @Matricula_alumno char(10), @Numero_orden char(10), @Fecha date
as
  begin
  insert into Examina values(@Num_tribunal, @Matricula_alumno, @Numero_orden, @Fecha)
  end
go



/*PROCEDIMIENTOS ALMACENADOS PARA CARGAR LOS DATAGRIDVIEW*/
create procedure cargarGrupo
as
 begin
 Select * From Grupo
 end
go

create procedure cargarProfesor
as
  begin
  select * From Profesor
  end
go

create procedure cargarTFC
as
  begin
  select *  From TFC
  end
go

create procedure cargarTribunal
as
  begin
  select * From tribunal
  end
go

create procedure cargarAlumno
as 
  begin
  Select * From Alumno
  end
go

insert into Grupo values 
('12345', 'Grupo Sistemas', 5, 'Activo'),
('02321', 'Grupo Industrial', 10, 'Activo'),
('01235', 'Grupo Informatica', 15, 'Activo'),
('11002', 'Grupo Innovacion', 5, 'Activo')

insert into Profesor values
('12Q23', 'Roberto Zamudio Portilla', 'Comision', 'Activo'),
('01Q03', 'Jose Antonio', 'Rayon', 'Activo'),
('32QC5', 'Angel Guzman', 'Solidaridad', 'Activo'),
('09QV9', 'Alejandro Ventura', 'AV.Carranza', 'Activo')

insert into TFC values
('0000122355', '2022-10-02', 'Base de datos', 'Activo'),
('0946271282', '2022-12-06', 'Sistemas integrados', 'Activo'),
('9056331211', '2023-04-19', 'Lenguajes de interfaz', 'Activo')

insert into tribunal values
('00123', 'ITSCO', 10, 'Activo'),
('11025', 'instituo de alvarado', 5, 'Activo'),
('9872', 'Instituo tecnologico de Tuxtepec', 20,'Activo'),
('1902', 'LANIA', 25, 'Activo')




