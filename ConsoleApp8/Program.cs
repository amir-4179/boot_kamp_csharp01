#region tolist
using ConsoleApp8;
MyAppContext db = new MyAppContext();
//List<Student> st=db.students.ToList();
//foreach(Student student in st)
//{
//    Console.WriteLine($"{student.Id}.{student.FirstName}{student.LastName}");
//}
//Console.WriteLine("*******************************************************************");
//List<Teacher> te = db.teachers.ToList();
//foreach (Teacher teacher in te)
//{
//    Console.WriteLine($"{teacher.Id}.{teacher.FirstName}{teacher.LastName}");
//}
#endregion
#region Insert
////Student st1 = new Student();
////st1.FirstName = "naser";
////st1.LastName = "alikhani";
////db.students.Add(st1);
////db.SaveChanges();
//Teacher te1 = new Teacher();
//te1.FirstName = "fereshteh";
//te1.LastName = "alikhani";
//db.teachers.Add(te1);
//db.SaveChanges();
#endregion

#region update
Student st1 = db.students.FirstOrDefault(s => s.Id == 1);
if (st1 != null)
{
    st1.FirstName = "امیر";
    st1.LastName = "علیخانی";
    db.students.Update(st1);
    db.SaveChanges();
}
Teacher te = db.teachers.FirstOrDefault(t => t.Id == 1);
if (te != null)
{
    te.FirstName = "zahra";
    te.LastName = "darbani";
    db.teachers.Add(te);
    db.SaveChanges();
}
#endregion
#region delete
//Student st1 = db.students.FirstOrDefault(s => s.Id == 5);
//if(st1!=null)
//{
//    db.students.Remove(st1);
//    db.SaveChanges();
//}
#endregion