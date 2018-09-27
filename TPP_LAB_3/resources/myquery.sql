--Таблица поставщиков
CREATE TABLE Providers(
	id		   	   bigserial	NOT NULL,
	providername	   varchar(40)	NOT NULL,
	ownername	   varchar(20),
	notes	   	   varchar(50),	
	PRIMARY KEY	   (id));

--Таблица товаров
CREATE TABLE Products(
	id		   		bigserial	NOT NULL,
	name 	   		varchar(40) NOT NULL,
	description 	varchar(80),
	releasedate 	timestamp without time zone NOT NULL DEFAULT (current_timestamp AT TIME ZONE 'UTC'),
	price 		   	integer 	NOT NULL CHECK (price > 0),
	providerid 	   	bigint		NOT NULL,
	PRIMARY KEY	   	(id),
	FOREIGN KEY	   (providerid)	REFERENCES Providers	ON UPDATE CASCADE	ON DELETE CASCADE);
