using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_01_CRUD_ProcedureSQL.sql_stored_procedure
{
    public class ClassSqlServer
    {
		/*
         create database testdb

	use testdb

create table alumno(
	                id int identity(1,1),
	                nombre varchar(50),
	                ap_paterno varchar(50),
	                ap_materno varchar(50),
	                email varchar(50),
					banActivo bit default 1
	                primary key(id) 
                 );

create procedure SPSalumnos
                as 
                begin
	            select  id 'Clave alumno'
			            ,nombre 'Nombre'
			            ,ap_paterno 'Apellido paterno'
			            ,ap_materno 'Apellido materno'
			            ,email 'Correo'
		                from alumno
                end

--insert into alumno(nombre, ap_paterno, ap_materno, email)values('Jose','Guzman','Cruz','bfjose@gmail.com');

--select *from alumno

create proc SPIalumnos
	                @nombre varchar(50),
	                @ap_paterno varchar(50),
	                @ap_materno varchar(50),
	                @email varchar(50)
                as
                begin
	                insert into alumno(nombre,ap_paterno,ap_materno,email)
					            values(@nombre,@ap_paterno,@ap_materno,@email);
                end
--///////////////////////////////////////////////////////////////////////

create proc SPDalumnos
	                @id int
             as begin
	                delete from alumno where id=@id
             end

--//////////////

create procedure SPUlumnos
					@id int,
					@nombre varchar(60),
					@ap_paterno varchar(60),
					@ap_materno varchar(60),
					@email varchar(60)
			as 
			begin
					update alumno set nombre=@nombre, ap_paterno=@ap_paterno, ap_materno=@ap_materno, email=@email where id=@id
			end

declare @id int, 

exec SPUlumnos 'Jose-test','Guzman-test','Cruz-test','bfjose@gmail.com-test', @id

update alumno set nombre='Jose-test', ap_paterno='Guzman-test', ap_materno='Cruz-test', email='bfjose@gmail.com-test' where id=1

select *from alumno


------baneado o desbaneado

alter table alumno add banActivo bit default 1

update alumno set banActivo=1

create proc SPBajaAlumno
                 @id int
                 as begin
	                update alumno set banActivo=0
	             where id=@id
                 end
----------------------------------------------------------
ALTER procedure [dbo].[SPSalumnos]
                as 
                begin
	            select  id 'Clave alumno'
			            ,nombre 'Nombre'
			            ,ap_paterno 'Apellido paterno'
			            ,ap_materno 'Apellido materno'
			            ,email 'Correo'
		        from alumno
		            where banActivo = 1
                end

------------------------------------------------
create procedure SPSalumnosPorNombre
            @nombre varchar(50)
            as 
            begin
	            select  id 'Clave alumno'
			            ,nombre 'Nombre'
			            ,ap_paterno 'Apellido paterno'
			            ,ap_materno 'Apellido materno'
			            ,email 'Correo'
		            from alumno
		            where banActivo=1
		            and nombre like '%'+@nombre+'%'
            end
         
         */
	}
}