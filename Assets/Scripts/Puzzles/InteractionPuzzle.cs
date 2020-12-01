using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionPuzzle : Puzzle
{

    [SerializeField] private GameObject item;
    private Collider collider = null;

    //[SerializeField] FPC_InteractObject FPC_InteractObject;

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
        onPuzzleSolved.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        collider = other;
        if (CheckSolution())
        {
            SolutionAction();
        }
        collider = null;
    }
}
