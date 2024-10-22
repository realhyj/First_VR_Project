using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(bullet, 10f);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Target")
        {
            Destroy(gameObject);
        }
    }
}
