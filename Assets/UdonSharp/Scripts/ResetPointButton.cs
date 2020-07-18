using System.Collections;
using System.Collections.Generic;
using UdonSharp;
using UnityEngine;

public class ResetPointButton : UdonSharpBehaviour
{
    [SerializeField]
    public UdonSharpBehaviour[] goalBoards;

    public void Reset()
    {
        foreach(var goalBoard in goalBoards)
        {
            goalBoard.SetProgramVariable("_score", 0);
        }
    }

    private void OnMouseDown()
    {
        Reset();
    }
    public override void Interact()
    {
        Reset();
    }
}

