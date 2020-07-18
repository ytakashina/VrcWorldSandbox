
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Sphere : UdonSharpBehaviour
{
    void Start(){}

    public override void OnDrop()
    {

        var player = Networking.LocalPlayer;
        var velocity = player.GetVelocity();
        var pos = GetComponent<Rigidbody>().position;
        var posPlayer = player.GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position;
        GetComponent<Rigidbody>().velocity = velocity + 25 * (pos - posPlayer).normalized;
        //var rotation = player.GetRotation();
        //var forward = rotation * player.gameObject.GetComponent<Transform>().forward;
        //GetComponent<Rigidbody>().velocity = velocity + forward;
    }
}
