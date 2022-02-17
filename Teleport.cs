using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour {

    public Transform teleportTarget;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider Teleport)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }

}
