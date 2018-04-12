using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
    public OnlyATag[] ac;
    // Update is called once per frame
    void Update () {
        ac = GetComponentsInChildren<OnlyATag>();
        if(ac.Length == 0)
            Application.LoadLevel("cw");
    }
}
