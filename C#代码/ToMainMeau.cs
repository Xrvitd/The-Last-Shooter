using UnityEngine;
using System.Collections;
using UnityEngine.UI;//导入UI包

public class ToMainMeau : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void toClick()
    {
        Application.LoadLevel("start");
    }
}