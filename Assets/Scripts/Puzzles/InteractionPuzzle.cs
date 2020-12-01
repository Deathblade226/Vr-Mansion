using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionPuzzle : Puzzle
{
    [System.Serializable]
    public class InteractionEvent : UnityEvent { }

    public InteractionEvent onInteraction = new InteractionEvent();

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
        throw new System.NotImplementedException();
    }

    private void OnTriggerEnter(Collider other)
    {
        collider = other;
        if (CheckSolution())
        {
            onInteraction.Invoke();
        }
        collider = null;
    }
}
