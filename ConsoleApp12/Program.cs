//Record c# 9.0 dal geldi
//Record reference typedir
//Immutable dir
//Istifade yeri Dto lardir
//Record uzerinde ToString GetHashCode Equals methdolari hazir gelir
//Recordlar referance type olsalardabir bir leri ile yoxlama zamani
//deyerlere gore muqayise olunurlar

//class Program
//{
//    public record Person(string name, string surname);

//    static void Main(string[] args)
//    {
//        //Person person1 = new Person("Nazim", "Nazmli");
//        //Person person2 = new Person("Nazim", "Nazmli");
//        //Console.WriteLine(person1);
//        //Console.WriteLine(person2);
//        //Console.WriteLine(person1==person2);
//    }




using Models;

List<Student> students = new List<Student>()
{
    new Student { Name = "Elnur", Surname = "Aliyev", BDate = new DateTime(2000, 5, 10), Score = 85 },
    new Student { Name = "Aysel", Surname = "Mustafayeva", BDate = new DateTime(1999, 12, 3), Score = 78 },
    new Student { Name = "Rashad", Surname = "Huseynov", BDate = new DateTime(2001, 8, 20), Score = 92 },
    new Student { Name = "Narmina", Surname = "Jafarova", BDate = new DateTime(2002, 3, 15), Score = 80 },
    new Student { Name = "Elchin", Surname = "Quliyev", BDate = new DateTime(2003, 6, 25), Score = 88 },
    new Student { Name = "Leyla", Surname = "Mammadova", BDate = new DateTime(2000, 9, 12), Score = 76 },
    new Student { Name = "Vugar", Surname = "Safarov", BDate = new DateTime(1999, 11, 8), Score = 84 },
    new Student { Name = "Gulnar", Surname = "Rzayeva", BDate = new DateTime(2001, 2, 28), Score = 90 },
    new Student { Name = "Farid", Surname = "Aliyev", BDate = new DateTime(2002, 7, 7), Score = 79 },
    new Student { Name = "Sevinj", Surname = "Abdullayeva", BDate = new DateTime(2003, 4, 18), Score = 87 },
    new Student { Name = "Orxan", Surname = "Ismayilov", BDate = new DateTime(2000, 10, 30), Score = 82 },
    new Student { Name = "Aytac", Surname = "Mammadov", BDate = new DateTime(1999, 1, 5), Score = 71 },
    new Student { Name = "Aysun", Surname = "Quliyeva", BDate = new DateTime(2001, 4, 22), Score = 75 },
    new Student { Name = "Nigar", Surname = "Huseynova", BDate = new DateTime(2002, 11, 14), Score = 83 },
    new Student { Name = "Rauf", Surname = "Suleymanov", BDate = new DateTime(2003, 8, 8), Score = 89 },
};




//students.ForEach(student => Console.Write(student));  //Dovr olaraq isleyir

//var st = students.Find(p => p.BDate.Year < 2000);  //Find element axtari yalniz bir element

//students.Where(p=>p.BDate.Year <2000).ToList().ForEach(p =>Console.WriteLine(p));

//students.RemoveAll(x => x.Name == "Sevinj"); Verilen serte uygun element silir

//students.ForEach(students =>Console.WriteLine(students));

//var count = students.Count(x => x.Score < 80); VErilen serte uygun sayir
//Console.WriteLine(count);

//var student = students.FirstOrDefault(student => student.Name == "Fikret",new Student("Anonim","Pikasso", new DateTime(1999, 1, 5),12));  eger verilen serte uygun olan element olduqda hemen elementeni obyekti geri qaytarir yoxsa default verdiyimiz deyeri qaytarir
//Console.WriteLine(student);


//var st = students.SingleOrDefault(x => x.Name == "Rauf"); verilen serte uygun 1 obyekt inu geri qaytarir yox eyni serty uygun 2ci element olduqda exception atir


//var nameOfStudens = students.Select(s=>s.Name).ToList();
//foreach (var item in nameOfStudens)
//{
//    Console.WriteLine(item);
//}

//List<string> names = new List<string>() { };

//foreach (var student in students)
//{
//    names.Add(student.Name);
//}


//var studs = students.Where(s => s.Score > 90)
//                    .Select(st => $"{st.Name} {st.Surname}")
//                    .Where(n => n.Count(c => c == 'a') == 2)
//                    .ToList();

//studs.ForEach(stud =>Console.WriteLine(stud));


