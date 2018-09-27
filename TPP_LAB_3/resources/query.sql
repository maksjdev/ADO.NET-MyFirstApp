--Таблица групп
CREATE TABLE Groups(
	id		   bigserial	NOT NULL,
	groupname	   varchar(20),
	curatorname	   varchar(20),
	headmanname	   varchar(20),	
	PRIMARY KEY	   (id));

--Таблица студентов
CREATE TABLE Students(
	id		   bigserial	NOT NULL,
	firstname 	   varchar(20),
	lastname 	   varchar(20),
	sex 		   varchar(1)	NOT NULL CHECK (sex = 'М' or sex = 'Ж'),
	age 		   integer,
	groupid 	   bigint,
	PRIMARY KEY	   (id),
	FOREIGN KEY	   (groupid)	REFERENCES Groups	ON UPDATE CASCADE	ON DELETE CASCADE);
