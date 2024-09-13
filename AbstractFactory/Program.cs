using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
    }

    namespace AbstractFactoryPattern
    {

        abstract class AbstractBottle
        {
            public abstract void Interact(AbstractWater water);
        }


        abstract class AbstractWater { }


        class CocaColaBottle : AbstractBottle
        {
            public override void Interact(AbstractWater water)
            {

            }
        }

        class PepsiBottle : AbstractBottle
        {
            public override void Interact(AbstractWater water)
            {

            }
        }


        class CocaColaWater : AbstractWater { }


        class PepsiWater : AbstractWater { }


        abstract class AbstractFactory
        {
            public abstract AbstractBottle CreateBottle();
            public abstract AbstractWater CreateWater();
        }


        class CocaColaFactory : AbstractFactory
        {
            public override AbstractBottle CreateBottle()
            {
                return new CocaColaBottle();
            }

            public override AbstractWater CreateWater()
            {
                return new CocaColaWater();
            }
        }


        class PepsiFactory : AbstractFactory
        {
            public override AbstractBottle CreateBottle()
            {
                return new PepsiBottle();
            }

            public override AbstractWater CreateWater()
            {
                return new PepsiWater();
            }
        }


        class Client
        {
            private AbstractBottle bottle;
            private AbstractWater water;

            public Client(AbstractFactory factory)
            {
                bottle = factory.CreateBottle();
                water = factory.CreateWater();
            }

            public void Run()
            {
                bottle.Interact(water);
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
            }
        }
    }
}