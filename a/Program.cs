using System;

    namespace miLibreria{
            abstract class Persona{

            public string nombre;
            public int dni;

            public void caminar(){
                Console.WriteLine("Caminando....");
            }          

            public string correr(){
                return "corriendo...";
            }     

            public abstract void llorar();
    }

    class alumno : Persona {

        public int dni;
        public void rendir(){
            Console.WriteLine("Rindiendo...");
        }

        public override void llorar()
        {
            Console.WriteLine("Subime la nota gogogo....");
        }
    }

    class Profesor : Persona{

        public int sueldo;

        public void tomarExamen(){
            Console.WriteLine("Tomando examen....");
    
        }

        public override void llorar(){
            Console.WriteLine("Subime el sueldo....");
        }
        
            
        }

    }
