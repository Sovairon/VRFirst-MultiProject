using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkedPlayer : Photon.MonoBehaviour {
    // Use this for initialization
    void Start () {
        Debug.Log("Instantiated");

        }
	
	// Update is called once per frame
	void Update () { //In every frame, this function sends position and rotation updates to photon server so that everything is synchronized.
        if (photonView.isMine)
        {
            transform.position = ViveManager.Instance.head.transform.position;
            transform.rotation = ViveManager.Instance.head.transform.rotation;

        }
    }
}
