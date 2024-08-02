using System.Collections;
using System.Data;
using System.Net.Http.Headers;
using miLibreria;

    class Principal{

        static void Main(){

            alumno Camila = new alumno();
            Profesor Diego = new Profesor();

            Camila.caminar();
            Camila.rendir();
            Camila.llorar();
            
            Diego.tomarExamen();
            Diego.llorar();
        }
    }