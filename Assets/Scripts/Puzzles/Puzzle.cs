using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Puzzle : MonoBehaviour
{
    public abstract bool CheckSolution();
    public abstract void SolutionAction();
}
