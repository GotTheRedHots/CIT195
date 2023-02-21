using System;
using System.Drawing;
using System.Xml;

namespace Inheritance;
    class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}
class Cat : Animal
{
    public string breed;  // accessible from any class
    protected int age;
    protected string disposition;   //accessible from derived classes

    public void setAge(int age)
    {
        this.age = age;
    }
    public virtual int getAge()
    {
        return age;
    }

    // access name through base because it is private
    public override string getName()
    {
        return base.getName();
    }

    // access type directly because it is protected and this is a derived class
    public override string getType()
    {
        return type;
    }

    public void setDisposition(string disp)
    {
        this.disposition = disp;
    }
    public virtual string getDisposition()
    {
        return disposition;
    }

    public virtual string sound()
    {
        return "meow a lot";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myPet = new Animal();
        myPet.setName("bubbles");
        myPet.setType("Cow");
        myPet.color = "brown";
        Console.WriteLine($"I am an animal and my name is {myPet.getName()}, I am a {myPet.getType()}, and I am {myPet.color}.");

        Cat myKitty = new Cat();
        myKitty.setName("Johnson");
        myKitty.setType("cat");
        myKitty.color="tan";
        myKitty.setAge(1);
        myKitty.breed = "Siamese";
        myKitty.setDisposition("kindof a jerk");

        Console.WriteLine($"I am an animal and my name is {myKitty.getName()}, I am a {myKitty.getType()}, and I am {myKitty.color}." +
            $" I am {myKitty.getAge()} years old, my breed is {myKitty.breed} and I am {myKitty.getDisposition()}.");
    }
}