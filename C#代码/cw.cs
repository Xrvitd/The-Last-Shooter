using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    float m_timer = 0;
    void Update()
    {
        m_timer += Time.time;
        if (m_timer >= 10000)
        {
            Application.LoadLevel("win");
            return;
        }
    }

}
