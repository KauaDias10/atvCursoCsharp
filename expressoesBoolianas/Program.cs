string permission = "Admin|Manager";
int level = 53;


if (permission.Contains("Admin"))
{
    if (level > 55){
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else{
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager")){
    if (level >= 20){
        Console.WriteLine("Welcome, Manager user.");
    }
    else{
        Console.WriteLine("Contact an Admin for access.");
    }
}
else{
    Console.WriteLine("You do not have sufficient privileges.");
}

/*Operadores Ternarios
string result = permission.Contains("Admin")
    ? (level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.")
    : (permission.Contains("Manager")
        ? (level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")
        : "You do not have sufficient privileges.");

Console.WriteLine(result);
*/
