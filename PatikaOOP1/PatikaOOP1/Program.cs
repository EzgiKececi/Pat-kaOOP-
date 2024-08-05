using PatikaOOP1;

public class Program
{
    public static void Main()
    {
        // Person sınıfından nesneler oluşturma
        Person student1 = new Person();
        student1.Name = "Mete";
        student1.Surname = "Gazoz";
        student1.BirthDate = 1999;

        Person student2 = new Person();
        student2.Name = "Buse";
        student2.Surname = "Sürmeneli";
        student2.BirthDate = 1998;

        Person teacher1 = new Person();
        teacher1.Name = "Göktuğ";
        teacher1.Surname = "Ergin";
        teacher1.BirthDate = 1984;

        Person teacher2 = new Person();
        teacher2.Name = "Cahit";
        teacher2.Surname = "Sürme";
        teacher2.BirthDate = 1985;

        //Person sınıfındaki metodları ilgili kişiler için çağırma
        student1.StudentInfo();
        Console.WriteLine();
        student2.StudentInfo();
        Console.WriteLine();
        teacher1.TeacherInfo();
        Console.WriteLine();
        teacher2.TeacherInfo();
    }
}

