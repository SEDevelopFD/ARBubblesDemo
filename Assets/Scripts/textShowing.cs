using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class textShowing : MonoBehaviour {

    public TextMesh myTextMesh;
    public GameObject obj;
    Dictionary<Vector3, string> dict;

//    ArrayList texts = new ArrayList();

    TextMesh[] texts = new TextMesh[15];

	// Use this for initialization
	void Start () {
   //     myTextMesh = new TextMesh();
  //      myTextMesh = gameObject.AddComponent<TextMesh>() as TextMesh;
        dict = new Dictionary<Vector3, string>();
        Vector3 pos = new Vector3(-2, 2, 0);
        dict[pos] = "Welcom to ar8UBBLEs!";
    //    pos = new Vector3(1, 1, 0);
      //  dict[pos] = "the second!";

//        int len = dict.Count;
        for (int i = 0; i < 1; ++i)
        {
            GameObject x = new GameObject();
            texts[i] = x.AddComponent<TextMesh>() as TextMesh;
						texts[i].text = dict[dict.Keys.ElementAt(i)];
						texts[i].transform.position = dict.Keys.ElementAt(i);

						texts[i].characterSize = 0.1f;
						texts[i].fontSize = 40;
                 //       texts[i].color = new Vector3();
		//				if(i == 0) texts[i].transform.parent = Camera.main.transform;
        }

	}

	// Update is called once per frame
	void Update () {
        //        myTextMesh.text = "hello world!";
        //      Vector3 pos = new Vector3(0, 0, 10);
        //    myTextMesh.transform.position = pos;

//        int len = dict.Count;
//        for (int i = 0; i < len; ++i) {
//            texts[i].text = dict[dict.Keys.ElementAt(i)];
//            texts[i].transform.position = dict.Keys.ElementAt(i);
//						float x = 0.1f;
//						texts[i].characterSize = x;
//						texts[i].fontSize = 10;
//						if(i == 0) texts[i].transform.parent = Camera.main.transform;
//        }
	}
}
