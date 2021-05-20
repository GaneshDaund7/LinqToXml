using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //XDocument XMLDoc = new XDocument(
            //    new XDeclaration("1.0","UTF-8","Yes"),
            //    new XComment("Creating an Xml Comment"),
            //    new XElement("Students",
            //       from Students in Student.GetAllDetails()
            //       select new XElement("Student",new XAttribute("Id",Students.id) 
            //                                     ,new XElement("Name",Students.name)
            //                                     ,new XElement("Gender",Students.Gender)
            //                                     ,new XElement("Marks",Students.Marks)
                                                 
                                                 
            //                          ))
            //    );


           
            //XMLDoc.Save(@"C:\Users\Lenovo\Documents\Visual Studio 2010\Projects\LinqToXML\LinqToXML\Data.xml");






            var name=from student in XDocument.Load(@"C:\Users\Lenovo\Documents\Visual Studio 2010\Projects\LinqToXML\LinqToXML\Data.xml")

                         .Descendants("Student")
                         select student;


                     foreach(var res in name)
                        Console.WriteLine(res);













            Console.ReadLine();
                
               
        }
    }
}
