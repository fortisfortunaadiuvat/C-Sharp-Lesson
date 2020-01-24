using System;

namespace InterfaceByMade
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);

            if(buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine($"The {buick.Brand} can not be driven!");
            }

            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powerbutton = new PowerButton(TV);

            powerbutton.Execute();
            powerbutton.Undo();
        }
    }
}
