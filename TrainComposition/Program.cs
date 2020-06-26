using System;
using System.Collections.Generic;

public class TrainComposition
{
    LinkedList<int> linkedLists = new LinkedList<int>();
 
    public void AttachWagonFromLeft(int wagonId)
    {
        linkedLists.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        linkedLists.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        var result = linkedLists.First.Value;
        linkedLists.RemoveFirst();
        return result;
    }

    public int DetachWagonFromRight()
    {
        var result = linkedLists.Last.Value;
        linkedLists.RemoveLast();
        return result;
    }

    public static void Main(string[] args)
    {
        TrainComposition train = new TrainComposition();
        train.AttachWagonFromLeft(7);
        train.AttachWagonFromLeft(13);
        Console.WriteLine(train.DetachWagonFromRight()); // 7 
        Console.WriteLine(train.DetachWagonFromLeft()); // 13
    }
}
