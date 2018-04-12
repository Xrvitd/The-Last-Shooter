using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour {
    public float m_timer;
    // Use this for initialization
    void Start () {
        m_timer = 0;
	}
    public static float killTime = 5;
	// Update is called once per frame
	void Update () {
        m_timer = Time.timeSinceLevelLoad;
        if (m_timer >= killTime)
        {
            Destroy(this.gameObject);
        }
    }
}
