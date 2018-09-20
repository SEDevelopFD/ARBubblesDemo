using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class setPlayer : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		this.transform.position = Camera.main.transform.position;
		this.transform.rotation = Camera.main.transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		if(this.hasAuthority){
            
			this.transform.position = Camera.main.transform.position;
            Vector3 p = Camera.main.transform.rotation.eulerAngles;
            this.transform.rotation = Quaternion.Euler(0, p.y, 0);
           
		}
	}
}
