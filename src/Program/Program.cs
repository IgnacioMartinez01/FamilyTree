using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            

           

            Person p1 = new Person("Ignacio",20);
            Person p2 = new Person ("Tomas",19);
            Person p3 = new Person("Bruno",20);
            Person p4 = new Person("Marcelo",20);
            Person p5 = new Person("Jorge",20);
            Person p6 = new Person("Gaston",20);
            Person p7 = new Person("Juan",20);
            Person p8 = new Person("Ricardo",20);

            Node n1 = new Node(p1);
            Node n2 = new Node(p2);
            Node n3 = new Node(p3);
            Node n4 = new Node(p4);
            Node n5 = new Node(p5);
            Node n6 = new Node(p6);
            Node n7 = new Node(p7);
            Node n8 = new Node(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n2.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            TotalEdad total=new TotalEdad();
            total.Visitado(n1);
            MayorHijo mayor=new MayorHijo();
            mayor.Visitado(n1);
            Console.Write(total.Total);
            Console.Write(mayor.Mayor);
            // visitar el árbol aquí
        }
    }
}
