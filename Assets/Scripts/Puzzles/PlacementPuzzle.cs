using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlacementPuzzle : Puzzle
{
    [SerializeField] private List<GameObject> items;
    [SerializeField] private List<GameObject> locations;

    private List<GameObject> addedObjects = new List<GameObject>();

    [SerializeField] private bool isLocationsImportant = false;

    private void OnValidate()
    {
        if (items.Count != locations.Count)
        {
            Debug.LogWarning("Items and Locations need to be the size to work properly.");
        }
    }
    public override bool CheckSolution()
    {
        bool isSolved = false;
        isSolved = true;
        //if (isLocationsImportant)
        //{
            for (int i = 0; i < items.Count; i++)
            {
                if (locations[i].transform.position != items[i].transform.position)
                {
                    isSolved = false;
                }
            }
        //}

        return isSolved;
    }

    public override void SolutionAction()
    {
        onPuzzleSolved.Invoke();
    }

    public void ObjectAdded(GameObject objectAdded)
    {
        addedObjects.Add(objectAdded);
    }

    public void ObjectRemoved(GameObject objectRemoved)
    {
        addedObjects.Remove(objectRemoved);
    }

    private void Update()
    {
        if (CheckSolution())
        {
            SolutionAction();
        }
    }
}
