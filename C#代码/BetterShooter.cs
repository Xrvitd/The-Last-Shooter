using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterShoot : MonoBehaviour
{

   /* private Camera _camera;
    private GameObject bullet;
    public GameObject enemy;
    public static int speed = 1;
    public static int HP = 5;
    public static bool leve = true;
    private int n = 1;
    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();  //获取Camera组件  
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
        if (leve && n == 1 && Physics.Raycast(ray, out hit, 600, mask.value))
        {
            GameObject hitObject = hit.transform.gameObject;
            hitObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
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
                if(hitObject.GetComponent<Health>().getHP() == 1)
                {
                    Destroy(hitObject);
                }
                hitObject.GetComponent<Heanth>().kill();
            }
        }
        
    }
    */
}
