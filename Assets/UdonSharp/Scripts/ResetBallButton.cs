using System.Collections;
using System.Collections.Generic;
using UdonSharp;
using UnityEngine;

public class ResetBallButton : UdonSharpBehaviour
{
    [SerializeField]
    public GameObject ball;

    [SerializeField]
    public Vector3 defaultBallPosition;

    public void Reset()
    {
        ball.transform.position = defaultBallPosition;
        ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0);
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

