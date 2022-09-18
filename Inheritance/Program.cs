using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
                            // TODO Be sure to follow best practice when creating your classes 

                                         // Create a class Animal -done
                                         // give this class 4 members that all Animals have in common -done


                                         // Create a class Bird -done
                                         // give this class 4 members that are specific to Bird -done
                                         // Set this class to inherit from your Animal Class -done

                                         // Create a class Reptile- done
                                         // give this class 4 members that are specific to Reptile -done 
                                         // Set this class to inherit from your Animal Class -done




                 /*Create an object of your Bird class
                  give values to your members using the object of your Bird class
                    *                                                                          -done
                    * Creatively display the class member values 
                     */
            var Bird = new Bird();
            
            Bird.HasFeathers=true;
            Bird.HasBeak=true;       //bird class
            Bird.HasHollowBones=true;
            Bird.WarmBlooded = "They are warm blooded animals";

            Bird.EatsFood=true;
            Bird.NumberOfLegs = 2;
            Bird.NumberOfEyes = 2; //animal class
            Bird.HasTail=true;  

                                            /*Create an object of your Reptile class
                                             *  give values to your members using the object of your Reptile class
                                             *                                                                                      -done
                                             * Creatively display the class member values 
                                             */
            var reptile = new Reptile();

            reptile.CanChangeColor=true;
            reptile.HasScales=true;       //reptile 
            reptile.HasShell=true;
            reptile.ColdBlooded = "They are cold blooded animals";

            reptile.NumberOfLegs = 4;    //thinking turtles and lizards not including snakes
            reptile.NumberOfEyes=2;
            reptile.HasTail=true;      //animal class
            reptile.EatsFood =true;

        }
    }
}
