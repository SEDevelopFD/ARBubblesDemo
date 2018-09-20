
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.iOS;

public class setOrigin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UnityARSessionNativeInterface.GetARSessionNativeInterface().SetWorldOrigin (this.transform);
	}

	// Update is called once per frame
	void Update () {

	}
}
