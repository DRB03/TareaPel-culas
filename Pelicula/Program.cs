using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos

        private string titulo;
        private int año;
        private string pais;
        private string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores

        public Pelicula(){}
        public Pelicula(string titulo,int año)
        {this.titulo=titulo;  this.año=año;}

        //Métodos

        public string GetTitulo(){return titulo;}
        public void SetTitulo(string titu){titulo=titu;}

        public int GetAño(){return año;}
        public void SetAño(int year){año=year;}
        
        public string GetPaís(){return pais;}
        public void SetPaís(string pa){pais=pa;}

        public string GetDirector(){return director;}
        public void SetDirector(string direc){director=direc;}
        
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
        }

        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void ImprimeActores()
        {
            foreach(Actor persona in actores)
            {
                Console.WriteLine($"{persona.GetNombre()} ({persona.GetAño()})");
            }
        }


    }

    public class Actor
    {
        //Propiedades
        string nombre;
        int año;

        //Constructores
        public Actor(){}
        public Actor(string nombre, int año)
        {this.nombre= nombre;  this.año=año;}

        //Métodos 
        public string GetNombre(){return nombre;}
        public void SetNombre(string nomb){nombre= nomb;}

        public int GetAño(){return año;}
        public void SetAño(int añe){año=añe;}

    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1=new Pelicula();
            Pelicula p2=new Pelicula();

            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0} ({1})", p1.GetTitulo(), p1.GetAño());
            p1.Imprime();

            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula("¿y donde estan las rubias?",2004));
            peliculas.Add(new Pelicula("Avatar 2",2023));
            peliculas.Add(new Pelicula("Divergente",2014));
            peliculas.Add(new Pelicula("Ready Player One",2018));
            peliculas.Add(new Pelicula("Una vida en nuestro Planeta",2020));

            foreach(Pelicula peli in peliculas)
            {
                peli.Imprime();
            }
            p1.AgregaActor(new Actor("Ryan Gosling", 1980));
            p1.AgregaActor(new Actor("Emma Stone", 1988));

            p1.ImprimeActores();
        }
        
    }
}

