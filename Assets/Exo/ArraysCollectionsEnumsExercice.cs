using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class ArraysCollectionsEnumsExercice : MonoBehaviour
{

    [SerializeField]
    string[] exoArray = new string[10];

    [ContextMenu("Reset Array")]
    void ResetArray()
    {
        Array.Resize(ref exoArray, 10);
    }

    [ContextMenu("Display Collection")]
    void DisplayCollection()
    {
        foreach (var item in collectionSelectioner) 
        {
            Debug.Log(item);
        }
        
    }

    [SerializeField]
    CollectionType chooseCollection;

    [SerializeField]
    Day myDay;

    public ICollection collectionSelectioner;

    private void Start()
    {
        switch (chooseCollection)
        {
            case CollectionType.Array:

                int[] intArray = {5, 8, 14};
                collectionSelectioner = intArray;
                break;

            case CollectionType.List:

                List <string> stingList = new();
                stingList.Add("Apple");
                stingList.Add("Banana");
                stingList.Add("Cherry");
                collectionSelectioner = stingList;
                break;
            
            case CollectionType.Stack:

                Stack stringStack = new Stack();
                stringStack.Push("Chandigarh");
                stringStack.Push("Delhi");
                stringStack.Push("Noida");
                collectionSelectioner = stringStack;
                break;

            case CollectionType.Queue:

                Queue<string> stringQueue = new Queue<string>();
                stringQueue.Enqueue("one");
                stringQueue.Enqueue("two");
                stringQueue.Enqueue("three");
                collectionSelectioner = stringQueue;
                break;

            default:
                break;
        }

        Debug.Log(myDay);
        
    }
}
