using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    private Camera _camera;
    private GameObject bullet;
    public  GameObject cw1;
    public GameObject cw2;
    public GameObject cw3;
    public GameObject cw4;
    public GameObject cw5;
    public GameObject cw6;
    public GameObject cw7;
    public GameObject cw8;
    public GameObject cw9;
    public GameObject cw10;
    public GameObject cw11;
    public GameObject cw12;
    public GameObject cw13;
    public GameObject cw14;
    public static int speed = 1;
    public static int HP = 5;
    public static bool leve = true;
    private int n = 1,toHP=HP,hp1 = HP, hp2 = HP, hp3 = HP, hp4 = HP, hp5 = HP, hp6 = HP, hp7 = HP, hp8 = HP, hp9 = HP, hp10 = HP, hp11 = HP, hp12 = HP, hp13 = HP, hp14 = HP;
    private bool v1;
    private bool v2;
    private bool v3;
    private bool v4;
    private bool v5;
    private bool v6;
    private bool v7;
    private bool v8;
    private bool v9;
    private bool v10;
    private bool v11;
    private bool v12;
    private bool v13;
    private bool v14;
    Random ro = new Random();
    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();  //获取Camera组件  
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public static int getRandoms( int min, int max)
    {
        int arr = 0;
        
        //表示键和值对的集合。
        Hashtable hashtable = new Hashtable();
        System.Random rm = new System.Random();
       
        
            //返回一个min到max之间的随机数
            int nValue = rm.Next(min, max);
            // 是否包含特定值
            if (!hashtable.ContainsValue(nValue))
            {
                //把键和值添加到hashtable
                hashtable.Add(nValue, nValue);
                arr = nValue;

                
            }
        
        return arr;
    }
    // Update is called once per frame
    void Update()
    {
        n++;
        n %= 10;
        Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
        Ray ray = _camera.ScreenPointToRay(point);
        RaycastHit hit;//定义一条射线投射后返回的信息  
        LayerMask mask = 1 << LayerMask.NameToLayer("233");
        //LayerMask mask1 = 1 << LayerMask.NameToLayer("233");
        
        

        if (leve&&n==1&&Physics.Raycast(ray, out hit, 600, mask.value))
        {
            GameObject hitObject = hit.transform.gameObject;
            //Destroy(hitObject);
            int rand = getRandoms(1, 100);
            if(rand%2==1)
            hitObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
            else
                hitObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetMouseButtonDown(0))
        {

            // GameObject b = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            // Rigidbody rgd = b.GetComponent<Rigidbody>();
            // rgd.velocity = transform.forward * speed;
            
            if (Physics.Raycast(ray, out hit, 600, mask.value))
            {
                //GameObject hitObject = hit.transform.gameObject;
                GameObject hitObject = hit.transform.gameObject;
                //Destroy(hitObject);
     
                if (hitObject.tag=="a1")
                {
                    if(hp1==1)
                    {
                        v1 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp1--;
                }
                if (hitObject.tag == "a2")
                {
                    if (hp2 == 1)
                    {
                        v2 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp2--;
                }
                if (hitObject.tag == "a3")
                {
                    if (hp3 == 1)
                    {
                        v3 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp3--;
                }
                if (hitObject.tag == "a4")
                {
                    if (hp4 == 1)
                    {
                        v4 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp4--;
                }
                if (hitObject.tag == "a5")
                {
                    if (hp5 == 1)
                    {
                        v5 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp5--;
                }
                if (hitObject.tag == "a6")
                {
                    if (hp6 == 1)
                    {
                        v6 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp6--;
                }
                if (hitObject.tag == "a7")
                {
                    if (hp7 == 1)
                    {
                        v7 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp7--;
                }
                if (hitObject.tag == "a8")
                {
                    if (hp8 == 1)
                    {
                        v8 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp8--;
                }
                if (hitObject.tag == "a9")
                {
                    if (hp9 == 1)
                    {
                        v9 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp9--;
                }
                if (hitObject.tag == "a10")
                {
                    if (hp10 == 1)
                    {
                        v10 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp10--;
                }
                if (hitObject.tag == "a11")
                {
                    if (hp11 == 1)
                    {
                        v11 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp11--;
                }
                if (hitObject.tag == "a12")
                {
                    if (hp12 == 1)
                    {
                        v12 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp12--;
                }
                if (hitObject.tag == "a13")
                {
                    if (hp13 == 1)
                    {
                        v13 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp13--;
                }
                if (hitObject.tag == "a14")
                {
                    if (hp14 == 1)
                    {
                        v14 = true;
                        Destroy(hitObject);
                    KillAndShowOff.showOff();
                    }
                    hp14--;
                }
               
         
                
            }
        }
        float dis = 999 ;
        if (!v1)
        {
            dis = Vector3.Distance(this.transform.position, cw1.transform.position);
        }
        
        if (dis <= 3)
        {
           
            Application.LoadLevel("die");
        }
        if (!v2)
            dis = Vector3.Distance(this.transform.position, cw2.transform.position);
        if (dis <= 3)
        {
           
            Application.LoadLevel("die");
        }
        if (!v3)
            dis = Vector3.Distance(this.transform.position, cw3.transform.position);
        if (dis <= 3)
        {
           
            Application.LoadLevel("die");
        }
        if (!v4)
            dis = Vector3.Distance(this.transform.position, cw4.transform.position);
        if (dis <= 3)
        {
         
            Application.LoadLevel("die");
        }
        if (!v5)
            dis = Vector3.Distance(this.transform.position, cw5.transform.position);
        if (dis <= 3)
        {
         
            Application.LoadLevel("die");
        }
        if (!v6)
            dis = Vector3.Distance(this.transform.position, cw6.transform.position);
        if (dis <= 3)
        {
          
            Application.LoadLevel("die");
        }
        if (!v7)
            dis = Vector3.Distance(this.transform.position, cw7.transform.position);
        if (dis <= 3)
        {
        
            Application.LoadLevel("die");
        }
        if (!v8)
            dis = Vector3.Distance(this.transform.position, cw8.transform.position);
        if (dis <= 3)
        {
         
            Application.LoadLevel("die");
        }
        if (!v9)
            dis = Vector3.Distance(this.transform.position, cw9.transform.position);
        if (dis <= 3)
        {
            
            Application.LoadLevel("die");
        }
        if (!v10)
            dis = Vector3.Distance(this.transform.position, cw10.transform.position);
        if (dis <= 3)
        {
            
            Application.LoadLevel("die");
        }
        if (!v11)
            dis = Vector3.Distance(this.transform.position, cw11.transform.position);
        if (dis <= 3)
        {
          
            Application.LoadLevel("die");
        }
        if (!v12)
            dis = Vector3.Distance(this.transform.position, cw12.transform.position);
        if (dis <= 3)
        {
         
            Application.LoadLevel("die");
        }
        if (!v13)
            dis = Vector3.Distance(this.transform.position, cw13.transform.position);
        if (dis <= 3)
        {
          
            Application.LoadLevel("die");
        }
        if (!v14)
            dis = Vector3.Distance(this.transform.position, cw14.transform.position);
        if (dis <= 3)
        {
           
            Application.LoadLevel("die");
        }
    }
    

}
