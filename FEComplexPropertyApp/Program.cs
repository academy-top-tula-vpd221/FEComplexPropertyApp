using EFModrelCreateApp;
using FEComplexPropertyApp;
using Microsoft.EntityFrameworkCore;

//using (ApplicationContext context = new ApplicationContext())
//{
//    context.Database.EnsureDeleted();
//    context.Database.EnsureCreated();

//    Employee bob = new Employee(
//        "Bob",
//        24,
//        new EmployeeProfile() { Login = "bobby", Password = "qwerty" }
//        );

//    Employee joe = new(
//        "Joe",
//        35,
//        new() { Login = "joseph", Password = "12345" }
//    );

//    context.Employees.AddRange(bob, joe);
//    context.SaveChanges();
//}

//using (ApplicationContext context = new ApplicationContext())
//{
//    var employees = context.Employees.ToList();
//    foreach(var e in employees)
//        Console.WriteLine($"Employee: {e}");
//}

using (ApplicationContext context = new ApplicationContext())
{
    //context.Database.EnsureDeleted();
    //context.Database.EnsureCreated();

    //Menu file = new Menu() { Title = "File" };
    //Menu edit = new Menu() { Title = "Edit" };
    //Menu help = new Menu() { Title = "Help" };

    //Menu newFile = new Menu() { Title = "New File" };
    //Menu openFile = new Menu() { Title = "Open File" };
    //Menu saveFile = new Menu() { Title = "Save File" };
    //file.Children.AddRange(new[] { newFile, openFile, saveFile });

    //Menu copyEdit = new Menu() { Title = "Copy", Parent = edit };
    //Menu cutEdit = new Menu() { Title = "Cut", Parent = edit };
    //Menu pasteEdit = new Menu() { Title = "Paste", Parent = edit };

    //context.Menu.AddRange(file, edit, help);
    //context.Menu.AddRange(copyEdit, cutEdit, pasteEdit);
    //context.SaveChanges();

    var mainmenu = context.Menu
                          .Where(m => m.Parent == null)
                          .Include(m => m.Children)
                          .ToList();
    foreach(var item in mainmenu)
    {
        Console.WriteLine(item.Title);
        foreach(var item2 in item.Children)
            Console.WriteLine($"\t{item2.Title}");
        Console.WriteLine("------");
    }
}