// Higher level module 

namespace DesignPatternLearning.src.SOLID.D
{
    public class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void startCar()
        {
            engine.start();
            Console.WriteLine("car start...");
        }
    }
}
