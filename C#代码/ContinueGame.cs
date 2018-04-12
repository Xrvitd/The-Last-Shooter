using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void click()
    {
        GameObject.Find("allCanvas").SendMessage("ESC.escShowDown()"); //能调用public和private类型函数
    }
}
