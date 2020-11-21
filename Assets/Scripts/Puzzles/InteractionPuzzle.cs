using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPuzzle : Puzzle
{
    [SerializeField] private GameObject item;
    private Collider collider = null;

    public override bool CheckSolution()
    {
        bool isSolved = false;

        if (collider.gameObject == item)
        {
            isSolved = true;
        }

        return isSolved;
    }

    public override void SolutionAction()
    {
        throw new System.NotImplementedException();
    }

    private void OnTriggerEnter(Collider other)
    {
        collider = other;
        if (CheckSolution())
        {
            Debug.Log("Proximity Puzzle Solved ");
        }
        collider = null;

    }
}
