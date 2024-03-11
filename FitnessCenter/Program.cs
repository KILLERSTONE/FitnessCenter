// See https://aka.ms/new-console-template for more information

using FitnessCenter.Admin;
using FitnessCenter.Model;
using FitnessCenter.Model.Class;


IServices services=new Services();

IUser user= new Employee(
    "Jeewan",21,
    new DateOnly(2002,07,24),"Male",
    new Address(21,"Baner Gaon","Baner","Pune",411045),
    "iLink",
    new Address(5,"PanCard Club","Baner","Pune",411045),
    "I309","7418720485","jeewan.ghimire@ilink-systems.com");

services.addUser(user);
services.printUser(user);

IUser user1=services.getUser("Jeewan",new DateOnly(2002,07,24),"","iLink");

services.removeUser(user);
services.printUsers();

services.editUser(user1,"Jeewan",
    new DateOnly(2002,07,24),
    new Address(21,"Baner Gaon","Baner","Pune",411045),
    22,"iLink Multitech",
    new Address(5,"PanCard Club","Baner","Pune",411045),"","jeewan.ghimire@ilink-systems.com","I309","7418720485");


services.printUser(user1);
    