using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public static float _speed = 2000;
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    // Start is called before the first frame update
    //void Start()
    //{
    //    Shoot(new Vector3(0, _speed, _speed * 10));
    //}
}
