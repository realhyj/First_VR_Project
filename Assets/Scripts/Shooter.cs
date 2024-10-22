using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject shootPoint;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab,shootPoint.transform.position,shootPoint.transform.rotation);
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        rigidbody.velocity = 10*gameObject.transform.forward;
    }
}
