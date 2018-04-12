using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAndShowOff : MonoBehaviour {

    public static GameObject panel;
    private static bool flag;
	// Use this for initialization
	void Start () {
        panel = GameObject.Find("killPanel");
        panel.SetActive(flag = false);
    }
	
    public static void showOff()
    {
        panel.SetActive(flag = true);
        x = 0;
        return;
    }
    static int x = 0;
    public int deadLine = 100;
	// Update is called once per frame
	void Update () {
        if (flag)
        {
            x++;
            if (x >= deadLine)
                x = 0;
                panel.SetActive(flag = false);
            }
        }
	}

