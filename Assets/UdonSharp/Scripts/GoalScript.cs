
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class GoalScript : UdonSharpBehaviour
{
    [SerializeField]
    public Vector3 defaultBallPosition;

    //https://hatuxes.hatenablog.jp/entry/2020/04/05/013323
    [UdonSynced(UdonSyncMode.None)]
    int _score;

    public Text scoreText;

    void Start()
    {
        _score = 0;
    }

    void Update()
    {
        scoreText.text = _score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _score++;

        GameObject something = collision.gameObject;
        something.transform.position = defaultBallPosition;
        something.GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0);
    }
}
