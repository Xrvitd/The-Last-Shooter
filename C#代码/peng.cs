using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peng : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  

void OnCollisionEnter(Collision collision)
{
if(collision.collider.tag=="enemy")//tag是物体的标签，相当于物体的类别名称。在每一个物体的组件栏（也就是加脚本的那个区域）的最上面可以找到，默认的是UnTagged，也就是没有标签，你找找，然后点击会出现一个下拉列表，默认的已有几个Tag，你也可以加自定义的，点击下拉列表最下方的Add Tag就可以加Tag，最后选择一个Tag作为物体的名称就可以了。
{
Destroy(collision.collider.gameObject);//如果检测到对方是敌人，则消灭对方。
}
}
}
