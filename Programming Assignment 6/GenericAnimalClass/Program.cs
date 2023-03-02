
using System;
public class Animal<T>
{
    public T data;

    public Animal(T data)
    {
        this.data = data;
    }
    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main()
    {
        Animal<string> animalName = new Animal<string>("Armadillo");
        Animal<string> animalHabitat = new Animal<string>("Desert Enclosure");
        Animal<bool> endangered= new Animal<bool>(false);
        Animal<bool> extinct= new Animal<bool>(false);
        Animal<int> averageLifespan = new Animal<int>(14);

        Console.WriteLine(animalName.getAnimal());
        Console.WriteLine(animalHabitat.getAnimal());
        Console.WriteLine(endangered.getAnimal());
        Console.WriteLine(extinct.getAnimal()); 
        Console.WriteLine(averageLifespan.getAnimal());
    }
}