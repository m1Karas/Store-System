
drop table sellHasProduct;
drop table sell;
drop table product;
drop table account;
drop table employee;


CREATE TABLE `store`.`product` (
 ID_Product   int not null unique,  
 Category     varchar (40) not null,    
 Name_Product varchar(180) not null,
 Price   float not null,
Quantity_Product int not null,
Descritpion  varchar(2000),
        
 primary key(ID_Product)
);

CREATE TABLE `store`.`account` (
 ID_User   int not null unique,  
 Name_User     varchar (40) not null unique,    
 Password_User varchar(40) not null,
 Lvl    int not null,
        
 primary key(ID_User)
);

CREATE TABLE `store`.`employee` (
 ID_Employee   int not null unique,  
 Name_Employee     varchar (40) not null,    
 Address    varchar(180),
    Phone    varchar(150),
    Salary    float,
    SSN     varchar(15),
        
 primary key(ID_Employee)
);

CREATE TABLE `store`.`sell`(
    ID_Sell INT NOT NULL UNIQUE,
    Date_Sell DATE NOT NULL,
    Value_Sell FLOAT NOT NULL,
    ID_Employee INT NOT NULL UNIQUE,
    
    primary key (ID_Sell),
    foreign key (ID_Employee) references `store`.`employee` (ID_Employee) 
);

 CREATE TABLE `store`.`sellHasProduct` (
	ID_Sell   int not null unique,
	ID_Product   int not null unique,  
	Quantity     int not null,
	ItemTotal  float,
	primary key(ID_Product, Quantity),
	foreign key (ID_Product) references `store`.`product` (ID_Product) on delete cascade,
	foreign key (ID_Sell) references `store`.`sell` (ID_Sell) on delete cascade
);

insert into `store`.`account` values (1, 'Admin', 'root', 1);

insert into `store`.`product` values (1, 'Shoes', 'Red Shoe', 19, 50, 'Feminine High hells red shoe');

select * from `store`.`account`;
select * from `store`.`product`;

-- SELECT Password_User FROM account WHERE Name_User = 'Admin';

UPDATE product SET Quantity_Product =  3  WHERE ID_Product =  1 ;

select * from `store`.`product`;