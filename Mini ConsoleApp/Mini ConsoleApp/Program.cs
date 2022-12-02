using Mini_ConsoleApp;


    //ferqli classa cixardin



    Console.WriteLine("---------------------------------------------------------------");
    Console.WriteLine("                     Xos gelmusuz                              ");

    do
    {
        Console.WriteLine("1.Create Classroom");
        Console.WriteLine("2.Create student");
        Console.WriteLine("3.Show all students");
        Console.WriteLine("4.Show all students from selected class");
        var choose = Console.ReadLine();
        switch (choose)
        {
            case "1":
                CreateClass();
                break;
            case "2":
              CreateStudent();
                break;
            case "3":
            ShowAllStudents();
                break;
        case "4":
            Console.WriteLine("Choose from which class");
            choose = Console.ReadLine();
            ShowStudentsAtClass(choose);
            break;
        default:
            
            break;
        }


    } while (true);




 static void CreateClass()
{
    Console.WriteLine("Classroom adi daxil edin");
    string name = Console.ReadLine();
    Console.WriteLine("Type secin back/front");
    string type = Console.ReadLine();
    string nameNew = Helper.CheckClassName(name);
    if (nameNew != null)
    {
        if (type.ToLower() == "back")
        {

            Classroom classroom = new Classroom(nameNew, Enums.BackEnd);
            Data.Addclassrooms(classroom);
        }
        else
        {
            Classroom classroom = new Classroom(Helper.CheckClassName(name), Enums.FrontEnd);
            Data.Addclassrooms(classroom);
        }
    }
    else
    {
        Console.WriteLine("Class yaranmadi");
    }

}


static void CreateStudent()
{
    if (Data.classrooms.Length>0)
    {
        Console.WriteLine("Еnter student Name");
        string name = Console.ReadLine();
        Console.WriteLine("Еnter student Surname");
        string surname = Console.ReadLine();
        bool nameNew = Helper.CheckName(name);
        bool surnameNew = Helper.CheckName(surname);
        Classroom classroom = new Classroom("AB102",Enums.FrontEnd);
        if (nameNew && surnameNew)
        {
            Student student = new Student(name, surname);
            Classroom.StudentAdd(student);
        }
        else
        {
            Console.WriteLine("the student has not been created");
        }
    }
    else
    {
        Console.WriteLine("Class does not exist!");
    }
    

}


static void ShowAllStudents()
{
    for (int i = 0; i < Data.classrooms.Length; i++)
    {
        for (int j = 0; j < Classroom.students.Length; j++)
        {
            Console.WriteLine(Classroom.students[i]);
        }
    }
}

static void ShowStudentsAtClass(string ClassName)
{
    for (int i = 0; i < Data.classrooms.Length; i++)
    {
        if (Classroom.students.Name==ClassName)
        {
            for (int j = 0; j < Classroom.students.Length; j++)
            {
                Console.WriteLine(Classroom.students[i]);
            }
        }
        else
        {
            Console.WriteLine("wrong name of class");
            break;
        }
    }
}
