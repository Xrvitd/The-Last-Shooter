using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Health[] en;
	// Update is called once per frame
	/*void Update () {
        en = GetComponentsInChildren<Health>();
        for(int i = 0;i < en.Length;i ++)
            if(Vector3.Distance(this.transform.position, en[i].transform.position) <= 3)
                Application.LoadLevel("die");
    }*/
}
