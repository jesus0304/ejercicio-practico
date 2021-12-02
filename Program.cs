using System;

espacio de nombres  Programa_04
{
     programa de clase
    {
        public  static  void  Main ( cadena [] argumentos )
        {
             
            string  dato  =  " " ;
            int  Tama ñ oPerro  =  0 ;
            int  ActividadPerro  =  0 ;
             peso  doble =  0 . 0 ;
            int  opcion  =  0 ;
            
            
            
            hacer {
                
                Consola . WriteLine ( " Bienvenidos a un programa de cuanto debe comer tu perro. \ N \ n " );
                
                
                
                Consola . WriteLine ( " ¿Cual es el peso de su perro ?: " );
                dato  =  Consola . ReadLine ();
                peso  =  Convertir . ToDouble ( dato );
                
                Consola . WriteLine ( " ¿Como considera la actividad de su mascota? " );
                Consola . WriteLine ( " 1 - Actividad Alta " );
                Consola . WriteLine ( " 2 - Actividad normal " );
                Consola . WriteLine ( " 3 - Actividad Baja " );
                dato  =  Consola . ReadLine ();
                ActividadPerro  =  Convertir . ToInt32 ( dato );
                
                
                // Tamaño Miniatura
                si ( peso  <=  5  &&  peso  > =  2 )
                {
                    
                    cambiar ( ActividadPerro ) {
                        caso  1 :
                            Consola . WriteLine ( " Su perro debe comer entre 60 - 115 gramos de alimento " );
                            romper ;
                        caso  2 :
                            Consola . WriteLine ( " Su perro debe comer entre 55 y 100 gramos. " );
                            romper ;
                        caso  3 :
                            Consola . WriteLine ( " Su perro debe comer entre 45 -85 gramos. " );
                            romper ;
                    }
                    
                }
                
                
                Consola . WriteLine ( " Si desea continuar escriba 1 \ n de lo contrario escriba 4 " );
                dato  =  Consola . ReadLine ();
                opcion  =  Convertir . ToInt32 ( dato );
                
                Consola . Borrar ();
                
                
            } while ( opcion  ! =  4 );
                        
            
        
            
            
        }
    }
}