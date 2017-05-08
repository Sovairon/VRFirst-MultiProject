using UnityEngine;
using System.Collections;

public class NetworkController : MonoBehaviour {
    string _room = "PhotonTest";
    public GameObject headPrefab;
	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings("0.1"); //This initializes photon network for the project
	}

    void OnConnectedToMaster() //This function is different in the documentation of Photon. Probably because the documentation is outdated.
    {
        Debug.Log("lobby join"); 

        RoomOptions roomOpts = new RoomOptions() { };
        PhotonNetwork.JoinOrCreateRoom(_room, roomOpts, TypedLobby.Default);
    }

    void OnJoinedRoom()
    { 
        SpawnPlayer();
    }

    private void SpawnPlayer() //For spawning players. it takes the model of the head of player, position and rotation values to set to the server.
    {
        PhotonNetwork.Instantiate(headPrefab.name, ViveManager.Instance.head.transform.position, ViveManager.Instance.head.transform.rotation, 0);
    }

    // Update is called once per frame
    void Update () {
	}
}
