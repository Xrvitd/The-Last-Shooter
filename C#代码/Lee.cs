using UnityEngine;
using System.Collections;
using UnityEngine.UI;//导入UI包

public class Lee : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        Button button = gameObject.GetComponent<Button>() as Button;//获取Button组件
        button.onClick.AddListener(toClick);//为button的OnClick事件添加监听器，当监听到Click事件时，回调myClick函数。
    }

    public void toClick()
    {
        Shoot.HP = 15;
        Shoot.leve = true;
        Shoot.speed = 100;
     
        Application.LoadLevel("war1");
        return;
    }
}