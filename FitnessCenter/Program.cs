// See https://aka.ms/new-console-template for more information

using FitnessCenter.Admin;
using FitnessCenter.Model;
using FitnessCenter.Model.Class;

IServices services = new Services();

IUser user = new Employee(
    "Jeewan", 21,
    new DateOnly(2002, 07, 24), "Male",
    new Address(21, "Baner Gaon", "Baner", "Pune", 411045),
    "iLink",
    new Address(5, "PanCard Club", "Baner", "Pune", 411045),
    "I309", "7418720485", "jeewan.ghimire@ilink-systems.com");

services.addUser(user);
services.printUser(user);

var user1 = services.getUser("Jeewan", new DateOnly(2002, 07, 24), "", "iLink");


services.editUser(user1, "Jeewan",
    new DateOnly(2002, 07, 24),
    new Address(21, "Baner Gaon", "Baner", "Pune", 411045),
    22, "iLink Multitech",
    new Address(5, "PanCard Club", "Baner", "Pune", 411045), "", "jeewan.ghimire@ilink-systems.com", "I309",
    "7418720485");


services.printUser(user1);


Console.WriteLine("Welcome to Fitness Center Management System!");

while (true)
{
    Console.WriteLine("---------------------------------------------------------------------");
    Console.WriteLine("Enter 1 to add a user,");
    Console.WriteLine("Enter 2 to remove a user,");
    Console.WriteLine("Enter 3 to edit a user,");
    Console.WriteLine("Enter 4 to search for a user,");
    Console.WriteLine("Enter 5 to print all users,");
    Console.WriteLine("Enter 6 to exit.");
    Console.WriteLine("---------------------------------------------------------------------");

    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Mention 1 if the user is Employee and 2 if the user is Student else anything else");
            var choice2 = int.Parse(Console.ReadLine());

            switch (choice2)
            {
                case 1:
                    Console.Write("Enter name: ");
                    var sName = Console.ReadLine();

                    Console.Write("Enter age: ");
                    var sAge = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter date of birth (YYYY-MM-DD): ");
                    var sDob = DateOnly.Parse(Console.ReadLine());

                    Console.Write("Enter gender: ");
                    var sGen = Console.ReadLine();

                    Console.WriteLine("Enter home address details:");
                    Console.Write("Enter house number: ");
                    var sHouseNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter street: ");
                    var sStreet = Console.ReadLine();
                    Console.Write("Enter city: ");
                    var sCity = Console.ReadLine();
                    Console.Write("Enter state: ");
                    var sState = Console.ReadLine();
                    Console.Write("Enter postal code: ");
                    var sPostalCode = int.Parse(Console.ReadLine());
                    IAddress sHomeAddress = new Address(sHouseNumber, sStreet, sCity, sState, sPostalCode);

                    Console.Write("Enter company name: ");
                    var sCompanyName = Console.ReadLine();

                    Console.WriteLine("Enter office address details:");
                    Console.Write("Enter house number: ");
                    sHouseNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter street: ");
                    sStreet = Console.ReadLine();
                    Console.Write("Enter area: ");
                    sCity = Console.ReadLine();
                    Console.Write("Enter city: ");
                    sState = Console.ReadLine();
                    Console.Write("Enter postal code: ");
                    sPostalCode = int.Parse(Console.ReadLine());
                    IAddress officeAddress = new Address(sHouseNumber, sStreet, sCity, sState, sPostalCode);

                    Console.Write("Enter employee ID: ");
                    var employeeId = Console.ReadLine();

                    Console.Write("Enter phone number: ");
                    var phoneNumber = Console.ReadLine();

                    Console.Write("Enter email address: ");
                    var emailAddress = Console.ReadLine();

                    IUser emp = new Employee(sName, sAge, sDob, sGen, sHomeAddress, sCompanyName, officeAddress,
                        employeeId, phoneNumber, emailAddress);
                    services.addUser(emp);

                    Console.WriteLine("User added into the System");
                    break;

                case 2:
                    Console.WriteLine("Enter student details:");
                    Console.WriteLine("Name: ");
                    var eName = Console.ReadLine();
                    Console.WriteLine("Date of Birth (YYYY-MM-DD): ");
                    var eDob = DateOnly.Parse(Console.ReadLine());
                    Console.Write("Enter gender: ");
                    var eGen = Console.ReadLine();
                    Console.WriteLine("Age: ");
                    var eAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Address:");
                    Console.WriteLine("House Number: ");
                    var eHouseNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter street: ");
                    var eStreet = Console.ReadLine();
                    Console.Write("Enter city: ");
                    var eCity = Console.ReadLine();
                    Console.Write("Enter state: ");
                    var eState = Console.ReadLine();
                    Console.Write("Enter postal code: ");
                    var ePostalCode = int.Parse(Console.ReadLine());
                    IAddress eHomeAddress = new Address(eHouseNumber, eStreet, eCity, eState, ePostalCode);

                    Console.WriteLine("College Name: ");
                    var collegeName = Console.ReadLine();
                    Console.WriteLine("College Address:");
                    Console.WriteLine("House Number: ");
                    eHouseNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter street: ");
                    eStreet = Console.ReadLine();
                    Console.Write("Enter city: ");
                    eCity = Console.ReadLine();
                    Console.Write("Enter state: ");
                    eState = Console.ReadLine();
                    Console.Write("Enter postal code: ");
                    ePostalCode = int.Parse(Console.ReadLine());
                    IAddress collegeAddress = new Address(eHouseNumber, eStreet, eCity, eState, ePostalCode);
                    Console.WriteLine("Student ID: ");
                    var studentId = Console.ReadLine();
                    Console.WriteLine("Student Email: ");
                    var studentEmail = Console.ReadLine();

                    IUser student = new Student(eName, eAge, eDob, eGen, eHomeAddress, collegeName, collegeAddress,
                        studentId, studentEmail);
                    services.addUser(student);
                    Console.WriteLine("User added into the System");
                    break;

                default:
                    Console.WriteLine("Enter user details:");
                    Console.WriteLine("Name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Date of Birth (YYYY-MM-DD): ");
                    var dob = DateOnly.Parse(Console.ReadLine());
                    Console.WriteLine("Age: ");
                    var age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sex: ");
                    var sex = Console.ReadLine();
                    Console.WriteLine("Address:");
                    Console.WriteLine("House Number: ");
                    var houseNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter street: ");
                    var uStreet = Console.ReadLine();
                    Console.Write("Enter city: ");
                    var uCity = Console.ReadLine();
                    Console.Write("Enter state: ");
                    var uState = Console.ReadLine();
                    Console.Write("Enter postal code: ");
                    var uPostalCode = int.Parse(Console.ReadLine());
                    IAddress uHomeAddress = new Address(houseNumber, uStreet, uCity, uState, uPostalCode);

                    IUser u = new User(name, age, dob, sex, uHomeAddress);
                    services.addUser(u);
                    Console.WriteLine("User added successfully");
                    break;
            }

            break;
        case 2:
            Console.WriteLine("Enter the Name and DOB of user of delete from the System");

            var delName = Console.ReadLine();
            var delDob = DateOnly.Parse(Console.ReadLine());

            IUser toDelUser = services.getUser(delName, delDob);
            if (toDelUser != null)
            {
                services.removeUser(toDelUser);
                Console.WriteLine("Successfully removed from the System");
            }
            else
            {
                Console.WriteLine("No user associated to be deleted");
            }
            break;
        case 3:
            Console.WriteLine("Enter the name and DOB of the user you want to modify:");
            var getName = Console.ReadLine();
            var getDob = DateOnly.Parse(Console.ReadLine());

            var getUser = services.getUser(getName, getDob);

            if (getUser != null)
            {
                services.printUser(getUser);

                var name = getUser.name;
                var dob = getUser.dob;
                var age = getUser.age;
                var sex = getUser.sex;
                var address = getUser.address;

                Console.WriteLine("Enter the details you want to modify or enter 'x' for no change:");
                Console.WriteLine("Name Updated or Enter 'x': ");
                var input = Console.ReadLine();
                if (input.ToLower() != "x")
                    name = input;

                Console.WriteLine("Date of Birth Updated or Enter 'x': ");
                input = Console.ReadLine();
                if (input.ToLower() != "x")
                    dob = DateOnly.Parse(input);

                Console.WriteLine("Age Updated or Enter 'x': ");
                input = Console.ReadLine();
                if (input.ToLower() != "x")
                    age = int.Parse(input);

                Console.WriteLine("Sex Updated or Enter 'x': ");
                input = Console.ReadLine();
                if (input.ToLower() != "x")
                    sex = input;

                Console.WriteLine("Address Updated or Enter 'x': :");
                input = Console.ReadLine();
                if (input.ToLower() != "x")
                {
                    Console.WriteLine("House Number Updated");
                    var houseNumber = int.Parse(input);
                    Console.Write("Enter street: ");
                    var uStreet = Console.ReadLine();
                    Console.Write("Enter city: ");
                    var uCity = Console.ReadLine();
                    Console.Write("Enter state: ");
                    var uState = Console.ReadLine();
                    Console.Write("Enter postal code: ");
                    var uPostalCode = int.Parse(Console.ReadLine());
                    address = new Address(houseNumber, uStreet, uCity, uState, uPostalCode);
                }

                if (getUser is Employee)
                {
                    var emp = (Employee)getUser;
                    var companyName = emp.companyName;
                    var companyAddress = emp.companyAddr;
                    var empId = emp.empId;
                    var emailId = emp.emailId;
                    var phoneNo = emp.phoneNo;

                    Console.WriteLine("Company Name Updated or Enter 'x': ");
                    var companyNameInput = Console.ReadLine();
                    if (companyNameInput.ToLower() != "x")
                        companyName = companyNameInput;

                    Console.WriteLine("Company Address Updated or Enter 'x': ");
                    var companyHouseNumberInput = Console.ReadLine();
                    if (companyHouseNumberInput.ToLower() != "x")
                    {
                        Console.WriteLine("House Number: ");
                        var companyHouseNumber = int.Parse(companyHouseNumberInput);
                        Console.Write("Enter street: ");
                        var cStreet = Console.ReadLine();
                        Console.Write("Enter city: ");
                        var cCity = Console.ReadLine();
                        Console.Write("Enter state: ");
                        var cState = Console.ReadLine();
                        Console.Write("Enter postal code: ");
                        var cPostalCode = int.Parse(Console.ReadLine());
                        companyAddress = new Address(companyHouseNumber, cStreet, cCity, cState, cPostalCode);
                    }

                    Console.WriteLine("Employee ID Updated or Enter 'x': ");
                    var empIdInput = Console.ReadLine();
                    if (empIdInput.ToLower() != "x")
                        empId = empIdInput;

                    Console.WriteLine("Email ID Updated or Enter 'x': ");
                    var emailIdInput = Console.ReadLine();
                    if (emailIdInput.ToLower() != "x")
                        emailId = emailIdInput;

                    Console.WriteLine("Phone Number Updated or Enter 'x': ");
                    var phoneNoInput = Console.ReadLine();
                    if (phoneNoInput.ToLower() != "x")
                        phoneNo = phoneNoInput;


                    services.editUser(getUser, name, dob, address, age, companyName, companyAddress, null, emailId,
                        empId, phoneNo);
                    Console.WriteLine("Employee details updated successfully.");
                }
                else if (getUser is Student)
                {
                    var std = (Student)getUser;
                    var collegeName = std.collegeName;
                    var collegeAddress = std.collegeAddress;
                    var studentId = std.studentId;
                    var studentEmail = std.studentId;

                    Console.WriteLine("Enter the details you want to modify (or enter 'x' to keep it unchanged):");
                    Console.WriteLine("Name Updated or Enter 'x': ");
                    Console.WriteLine("College Name Updated or Enter 'x': ");
                    var companyNameInput = Console.ReadLine();
                    if (companyNameInput.ToLower() != "x")
                        collegeName = companyNameInput;

                    Console.WriteLine("College Address (x for unchanged):");
                    Console.WriteLine("Building Number Updated or Enter 'x': ");
                    var companyHouseNumberInput = Console.ReadLine();
                    if (companyHouseNumberInput.ToLower() != "x")
                    {
                        var companyHouseNumber = int.Parse(companyHouseNumberInput);
                        Console.Write("Enter street: ");
                        var cStreet = Console.ReadLine();
                        Console.Write("Enter city: ");
                        var cCity = Console.ReadLine();
                        Console.Write("Enter state: ");
                        var cState = Console.ReadLine();
                        Console.Write("Enter postal code: ");
                        var cPostalCode = int.Parse(Console.ReadLine());
                        collegeAddress = new Address(companyHouseNumber, cStreet, cCity, cState, cPostalCode);
                    }

                    Console.WriteLine("Student ID Updated or Enter 'x': ");
                    var empIdInput = Console.ReadLine();
                    if (empIdInput.ToLower() != "x")
                        studentId = empIdInput;

                    Console.WriteLine("Email ID Updated or Enter 'x': ");
                    var emailIdInput = Console.ReadLine();
                    if (emailIdInput.ToLower() != "x")
                        studentEmail = emailIdInput;


                    services.editUser(getUser, name, dob, address, age, collegeName, collegeAddress, studentId,
                        studentEmail, null, null);
                    Console.WriteLine("Student details updated successfully.");
                }
                else
                {
                    services.editUser(getUser, name, dob, address, age, null, null, null, null, null, null);
                    Console.WriteLine("User details updated successfully.");
                }
            }
            else
            {
                Console.WriteLine("No user found with the provided name and date of birth.");
            }

            break;
        case 4:
            Console.WriteLine("Enter the name and dob of the user that you want to search: ");
            var searchName = Console.ReadLine();
            var searchDate = DateOnly.Parse(Console.ReadLine());

            var searchedUser = services.getUser(searchName, searchDate);

            services.printUser(searchedUser);
            break;
        case 5:
            Console.WriteLine("Printing all user details: ");
            services.printUsers();
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}