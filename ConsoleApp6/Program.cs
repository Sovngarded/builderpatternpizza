using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добавить сыр? Д Н ");
            char input1 = Console.ReadKey().KeyChar;
            Console.WriteLine("Добавить томаты? Д Н");
            Console.WriteLine("Добавить оливки? Д Н ");
            Console.WriteLine("Добавить мясо? Д Н");
        }



        class Cheese { }
        class Tomatoes { }
        class Olives { }
        class Meat { }

        class Pizza
        {
            public Cheese Cheese { get; set; }
            public Tomatoes Tomatoes { get; set; }
            public Olives Olives { get; set; }
            public Meat Meat { get; set; }

        }

        abstract class PizzaBuilder
        {
            public Pizza Pizza { get; set; }

            public void CreatePizza()
            {
                Pizza = new Pizza();
            }
            public abstract void SetCheese();
            public abstract void SetTomatoes();
            public abstract void SetOlives();
            public abstract void SetMeat();
        }

        class PizzaMaker
        {
            public Pizza Bake(PizzaBuilder pizzaBuilder)
            {
                pizzaBuilder.CreatePizza();
                pizzaBuilder.SetCheese();
                pizzaBuilder.SetTomatoes();
                pizzaBuilder.SetOlives();
                pizzaBuilder.SetMeat();
                return pizzaBuilder.Pizza;
            }
        }

        class Margarita : PizzaBuilder
        {
            public override void SetTomatoes()
            {
                this.Pizza.Tomatoes = new Tomatoes();
            }
            public override void SetOlives()
            {
                this.Pizza.Olives = new Olives();
            }
            public override void SetCheese()
            {
                this.Pizza.Tomatoes = new Tomatoes();
            } public override void SetMeat()
            {
               
            }
        }
        class Carbonara : PizzaBuilder
        {
            public override void SetTomatoes()
            {
                this.Pizza.Tomatoes = new Tomatoes();
            }
            public override void SetOlives()
            {
                
            }
            public override void SetCheese()
            {
                this.Pizza.Tomatoes = new Tomatoes();
            }
            public override void SetMeat()
            {
                this.Pizza.Meat = new Meat();
            }
        }
        class Italian : PizzaBuilder
        {
            public override void SetTomatoes()
            {
                this.Pizza.Tomatoes = new Tomatoes();
            }
            public override void SetOlives()
            {
                this.Pizza.Olives = new Olives();
            }
            public override void SetCheese()
            {
                this.Pizza.Tomatoes = new Tomatoes();
            }
            public override void SetMeat()
            {
                this.Pizza.Meat = new Meat();
            }
        }
        class Pepperoni : PizzaBuilder
        {
            public override void SetTomatoes()
            {
                this.Pizza.Tomatoes = new Tomatoes();
            }
            public override void SetOlives()
            {
               
            }
            public override void SetCheese()
            {
                this.Pizza.Tomatoes = new Tomatoes();
            }
            public override void SetMeat()
            {
                this.Pizza.Meat = new Meat();
            }
        }


    }
}
