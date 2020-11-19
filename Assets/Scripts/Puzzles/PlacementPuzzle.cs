﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlacementPuzzle : Puzzle
{
    [SerializeField] private List<GameObject> items;
    [SerializeField] private List<GameObject> locations;

    private List<GameObject> addedObjects = new List<GameObject>();

    private void OnValidate()
    {
        if(items.Count != locations.Count)
        {
            Debug.LogWarning("Items and Locations need to be the size to work properly.");
        }
    }
    public override bool CheckSolution()
    {
        bool isSolved = true;
        if(items.Intersect(addedObjects).Count() == items.Count())
        {
            for (int i = 0; i < items.Count; i++)
            {
                if(locations[i].transform.position != addedObjects[i].transform.position)
                {
                    isSolved = false;
                }
            }
        }
        return isSolved;
    }

    public override void SolutionAction()
    {
        throw new System.NotImplementedException();
    }

    public void ObjectAdded(GameObject objectAdded)
    {
        addedObjects.Add(objectAdded);
    }
}
