using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPuzzle : Puzzle
{
    [SerializeField] private List<int> code;
    private List<int> enteredNumbers = new List<int>();

    public override bool CheckSolution()
    {
        bool isSolved = false;

        isSolved = (code.ToString().Equals(enteredNumbers.ToString()));

        return isSolved;
    }

    public override void SolutionAction()
    {
        throw new System.NotImplementedException();
    }

    public void ButtonClicked(int numPressed)
    {
        Debug.Log($"Button Pressed: {numPressed}");
        enteredNumbers.Add(numPressed);
    }

    public void ConfirmButtonPressed()
    {
        Debug.Log("Check Button Pressed");
        if(CheckSolution())
        {
            Debug.Log("Code Puzzle Solved");
        }
    }

    public void ResetButtonPressed()
    {
        Debug.Log("Reset Button Pressed");
        enteredNumbers = new List<int>();
    }
}
