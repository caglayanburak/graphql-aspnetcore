# graphql-aspnetcore

USE master 

CREATE DATABASE graphqldb 

USE graphqldb 

CREATE TABLE categories 
  ( 
     id   INT IDENTITY(1, 1), 
     NAME NVARCHAR(max), 
     PRIMARY KEY (id), 
  ); 

CREATE TABLE products 
  ( 
     id          INT IDENTITY(1, 1), 
     NAME        NVARCHAR(max), 
     price       MONEY, 
     description NVARCHAR(max), 
          PRIMARY KEY (id), 
     categoryid  INT FOREIGN KEY REFERENCES category(id) 
  ); 

USE graphqldb 

INSERT category 
VALUES('ayakkabı'); 

INSERT category 
VALUES('t-shirt'); 

INSERT category 
VALUES('cep telefonu') 

INSERT category 
VALUES('gömlek') 

INSERT category 
VALUES('pantolon') 

INSERT INTO products 
VALUES     ('adidas spor ayakkabı', 
            121, 
            'güzel ayakkabı', 
            1) 

INSERT INTO products 
VALUES     ('adidas t-shirt', 
            121, 
            'güzel t-shirt', 
            2) 

INSERT INTO products 
VALUES     ('adidas cep telefonu', 
            121, 
            'cep telefonu', 
            3) 

INSERT INTO products 
VALUES     ('adidas gömlek', 
            121, 
            'güzel gömlek', 
            4) 

INSERT INTO products 
VALUES     ('adidas pantolon', 
            121, 
            'güzel ayakkabı', 
            5) 

query example:
{ 
 "query":
  "query{
     category(id:2)
     {
     	id
     	name
     	products{
     		id
     		name
     	}
     }
   }"
}



