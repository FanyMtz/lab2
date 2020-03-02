CREATE TABlE videos(
idVideo int primary key,
titulo varchar(100),
repro int,
url varchar (100)
);

create procedure sp_video_insertar
@idvideo int,
@titulo varchar(100),
@repro int,
@url varchar(100)
as
begin
insert into videos values (@idvideo,@titulo,@repro,@url)
end 

