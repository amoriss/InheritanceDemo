using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C34InheritanceDemo;
internal class Retriever : Dog
{
    public bool Energetic { get; set; } = true;
    public string Personality { get; set; } = "docile";
    public bool Trainable { get; set; } = true;
    public string Name { get; set; }

    public void PrintRetrieverDetails()
    {
        Console.WriteLine($"Our dog named, {Name}, is an energetic dog, it's {Energetic}. \n" +
            $"She is has {Legs} legs. She loves the {Habitat}.\n" +
            $"She is trainable: {Trainable}.");
    }
}
