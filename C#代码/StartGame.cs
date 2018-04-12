using UnityEngine;
using System.Collections;
using UnityEngine.UI;//导入UI包

public class StartGame : MonoBehaviour
{
    GameObject leval;
    // Use this for initialization
    void Start()
    {
        leval = GameObject.Find("levalPanel");
        leval.SetActive(false);
        Button button = gameObject.GetComponent<Button>() as Button;//获取Button组件
        button.onClick.AddListener(toClick);//为button的OnClick事件添加监听器，当监听到Click事件时，回调myClick函数。
    }
    
    public void toClick()
    {
        leval.SetActive(true);
        GameObject.Find("startgamePanel").SetActive(false);
        return;
    }
}