using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaoJiShi : MonoBehaviour {

    // Use this for initialization
    float nowTime;
    void Start () {
        nowTime = 0.0f;
	}
    // Update is called once per frame
    void Update()
    {
        nowTime = Time.timeSinceLevelLoad;
    }

    private void OnGUI()
    {
        GUIStyle bb = new GUIStyle();
        bb.normal.background = null;    //这是设置背景填充的
        bb.normal.textColor = new Color(1.0f, 0.5f, 0.0f);   //设置字体颜色的
        bb.fontSize = 40;       //当然，这是字体大小

        if (nowTime < Disappear.killTime)
            GUI.Label(new Rect((Screen.width / 2) - 40, (Screen.height / 2) - 40, 200, 200), "距游戏开始还有" + (int)(Disappear.killTime - nowTime) + "秒", bb);
    }
}
