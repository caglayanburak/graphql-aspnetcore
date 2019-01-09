# graphql-aspnetcore

use master
create database GraphqlDb
use GraphqlDb
CREATE TABLE Categories (
   Id int identity(1,1),
   Name nvarchar(max),
 PRIMARY KEY (Id),
);
CREATE TABLE Products (
    Id int identity(1,1),
    Name nvarchar(max),
	Price money,
    Description nvarchar(max),
 PRIMARY KEY (Id),
    CategoryId int FOREIGN KEY REFERENCES Category(Id)
);

use GraphqlDb
insert category values('ayakkabı');
insert category values('t-shirt');
insert category values('cep telefonu')
insert category values('gömlek')
insert category values('pantolon')

insert into products values('adidas spor ayakkabı',121,'güzel ayakkabı',1)
insert into products values('adidas t-shirt',121,'güzel t-shirt',2)
insert into products values('adidas cep telefonu',121,'cep telefonu',3)
insert into products values('adidas gömlek',121,'güzel gömlek',4)
insert into products values('adidas pantolon',121,'güzel ayakkabı',5)



