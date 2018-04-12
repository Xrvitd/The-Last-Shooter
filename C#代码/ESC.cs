using UnityEngine;
using System.Collections;

public class ESC : MonoBehaviour
{
    public GameObject exitPanel = null; //面板  
    public GameObject normalCanvas = null;
    private static bool flag = false;

    public static bool getFlag()
    {
        return flag;
    }

    // Use this for initialization  
    void Start()
    {
        //normalCanvas.SetActive(true);
        exitPanel.SetActive(false);
    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!flag)
                escShowUp();
            else
                escShowDown();
        }
    }
    public void escShowUp()
    {
        exitPanel.SetActive(flag = true);
        normalCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
    }
    public void escShowDown()
    {
        exitPanel.SetActive(flag = false);
        normalCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
}