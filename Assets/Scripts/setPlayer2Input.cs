using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class setPlayer2Input : NetworkBehaviour{

	// Use this for initialization
	public TextMesh text;
	void Start () {
//		Debug.Log("player start");
			Invoke("setplayer",1);
	}
	void setplayer(){
//		Debug.Log("before if");
		if(this.hasAuthority) {
//			Debug.Log("in if");
			InputLoad.myload.myplayertext = this.text;
        }
	}

	// Update is called once per frame
	void Update () {

	}
}
