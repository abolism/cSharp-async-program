using System;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var music = choseMusic();
            //Console.WriteLine("music playing");

            var musicTask = playMusic(music);
            var clothesTask = getClothed(3);

            var musicPlaying = await musicTask;
            Console.WriteLine("music finished");

            var gettingClothed = await clothesTask;
            Console.WriteLine("got clothed");

            var doorTask = openningTheDoor();
            var carTask = startingCar();
            var openingDoor = await doorTask;
            Console.WriteLine("door Opened");

            
            var startingTheCar = await carTask;
            Console.WriteLine("car started");
        }
        static object choseMusic()
        {
            Console.WriteLine("chosed music");
            return new object();
        }
        static async Task<Object> playMusic(object obj)
        {
            Console.WriteLine("playing music");
            await Task.Delay(3000);
            return new object();
        }
        static async Task<Object> getClothed(int pieces)
        {
            Console.WriteLine("getting clothed");
            await Task.Delay(4000 * pieces);
            return new object();
        }
        static async Task<Object> openningTheDoor()
        {
            Console.WriteLine("opening the door");
            await Task.Delay(1500);
            return new object();
        }
        static async Task<Object> startingCar()
        {
            Console.WriteLine("starting car");
            await Task.Delay(5000);
            return new object();
        }
    }
    //public class Tasks
    //{

    //}
}
