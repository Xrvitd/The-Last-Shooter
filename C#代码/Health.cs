using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int enemyHP = 5;
    private int HP = 5;

	// Use this for initialization
	void Start () {
        HP = enemyHP;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void kill()
    {
        HP--;
    }

    public int getHP()
    {
        return HP;
    }
}
