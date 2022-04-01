using System;

namespace AddressBookLinq;

class Program
{
    public static void Main(string[] args)
    {
        List<Adress> listperson = new List<Adress>()
        {
            new Adress() { EmpId = 1, empFirstName = "Nirav", empLastName = "Raj", Address = "Gopal NAgar Durga MAndir", city = "Asansol", state="West Bengal", Zip="713340", email="niravpandit0002@gmail.com" },
            new Adress() { EmpId = 2, empFirstName = "DAvid Jhon", empLastName = "iGi", Address = "Claifornia 223", city = "Calfornia", state = "Continant", Zip = "713340", email = "David johon@gmail.com" },
            new Adress() { EmpId = 3, empFirstName = "Kassandra", empLastName = "Vein", Address = "kaloplis", city = "PDosidon", state = "Temple of Zeus", Zip = "713340", email = "Kassandra0002@gmail.com" },
            new Adress() { EmpId = 4, empFirstName = "Bayek", empLastName = "shiva", Address = "Giza", city = "Egypt", state = "mishr", Zip = "713340", email = "BAyek@gmail.com" }


        };

        foreach (var list in listperson)
        {
         Console.WriteLine("EmpId"+list.EmpId+"empFirstName:"+list.empFirstName );
        }

        //UC3 Adding New Contacts

        listperson.Add(new Adress() { EmpId = 1, empFirstName = "Vis", empLastName = "akaha", Address = "Gopal NAgar Durga MAndir", city = "Asansol", state = "West Bengal", Zip = "713340", email = "niravpandit0002@gmail.com", contact = 775667 });
        listperson.Add(new Adress() { EmpId = 1, empFirstName = "Vishal", empLastName = "Dute", Address = "", city = "Mahara", state = "Maharasrtra", Zip = "2213", email = "vishalDute@gmail.com", contact = 775667 });

        foreach (var list in listperson)
        {
            Console.WriteLine("EmpId" + list.EmpId + "empFirstName:" + list.empFirstName + "LatName" +list.empLastName) ;
         }



        //UC5
        //listperson.Remove(new Adress() { EmpId = 1, empFirstName = "Vis", empLastName = "akaha", Address = "Gopal NAgar Durga MAndir", city = "Asansol", state = "West Bengal", Zip = "713340", email = "niravpandit0002@gmail.com", contact = 775667 });


        MAnagmentAda m = new MAnagmentAda();

        m.Retrive(listperson);
        m.Size(listperson);
        m.Alpha(listperson);
        m.RetriveContact(listperson);


    }

}