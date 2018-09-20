using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class playersManage : NetworkBehaviour {
    // Use this for initialization
    [SyncVar]
    string text;

	void Start()
	{

	}

    // Update is called once per frame
    void Update()
    {
        if (hasAuthority) {
            CmdText(this.GetComponentInChildren<TextMesh>().text);
        }
        this.GetComponentInChildren<TextMesh>().text = text;
    }

    [Command]
    void CmdText(string t) {
        text = t;
    }
}
