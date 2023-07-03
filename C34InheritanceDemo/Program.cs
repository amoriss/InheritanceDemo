using C34InheritanceDemo;

//how to create an instance of dog

//three way to set property values
//1. dot notation
//2. custom constructor
//3. object initializer syntax


Dog dog1 = new Dog();
dog1.Breed = "Lab";
dog1.Gender = "girl";
dog1.Size = "small";
dog1.Habitat = "my living room";
dog1.HasFur = true;
dog1.Legs = 4;


Retriever r1 = new Retriever() 
{ 
    Habitat = "back yard", 
    Gender = "female", 
    Name = "Molly", 
    HasFur = true, 
    Legs = 4, 
    Size = "small" 
};
r1.PrintRetrieverDetails();

Animal[] array = new Animal[2];

array[0] = dog1;
array[1] = r1;

