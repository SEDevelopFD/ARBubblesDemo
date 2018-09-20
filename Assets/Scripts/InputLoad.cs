using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class InputLoad : NetworkBehaviour {
    private GameObject[] users;
    public TextMesh myplayertext;
    static public InputLoad myload;
    public InputField input;
    public Button bt;

//private NetworkIdentity NID;
//private string tt;

	// Use this for initialization
	void Start () {
	//	users = GameObject.GetGameObjectsWithTag("Player");
		myload=this;
        bt.onClick.AddListener(UserUpdateText);
	}

    void UserUpdateText(){
   //     if (hasAuthority){
        myplayertext.text = input.text;
        input.text = "";
     //   }
    }

	void Update(){
        /*
		if(myplayer!=null){
			tt = input.text;
    		NID = myplayer.GetComponentInParent<NetworkIdentity>();
    		if(NID.isServer){
    			Debug.Log("NID is server");
    			bt.onClick.AddListener(RcpInterval);

    		}
    		else{
    			Debug.Log("NID is not server");
    			bt.onClick.AddListener(CmdUpdateText);
    		}
	    }   
        */
	}


 /*
[Command]
	void CmdUpdateText(){
//			Debug.Log("before if");
			if(myplayer != null){
            
//				Debug.Log("ad=fter if");
//				Debug.Log(input.text);
//				Debug.Log(myplayer.GetComponent<NetworkIdentity>().netId);
				input.text = "";
//				Debug.Log(input.text);
				myplayer.text.text = tt;
				//RpcUpdateText(NID.netId, tmp);
			}
	}

	void RcpInterval(){
        input.text = "";
        Debug.Log(tt);
        if (NID != null)
        {
            RpcUpdateText(NID.netId, tt);
        }
	}

	[ClientRpc]
	void RpcUpdateText(NetworkInstanceId id, string t){
		Debug.Log(id);
		Debug.Log(t);
		Debug.Log("-----");
		if(myplayer != null){
		users = GameObject.FindGameObjectsWithTag("Player");
		foreach (GameObject user in users){
			Debug.Log(user.GetComponent<NetworkIdentity>().netId);
			if(user.GetComponent<NetworkIdentity>().netId==id){
				user.GetComponentInChildren<TextMesh>().text = t;
				break;
			}
	}
}
}
*/
}
