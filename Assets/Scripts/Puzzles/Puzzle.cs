using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Puzzle : MonoBehaviour
{
    [System.Serializable]
    public class InteractionEvent : UnityEvent { }

    public InteractionEvent onPuzzleSolved = new InteractionEvent();

    public abstract bool CheckSolution();
    public abstract void SolutionAction();
}
