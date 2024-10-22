using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] GameObject LeftTarget;
    [SerializeField] GameObject RightTarget;
    private Vector3 randomVector3;

    private void Start()
    {
        randomVector3 = new Vector3(0f, 1f, 3f);
        Instantiate(RightTarget, randomVector3, RightTarget.transform.rotation);
    }

    private void Update()
    {
        if (!GameObject.FindWithTag("Target"))
        {
            float x = Random.Range(-3f, 3f);
            float y = Random.Range(0f, 2f);
            float z = Random.Range(3f, 6f);
            randomVector3 = new Vector3(x, y, z);
            Instantiate(RightTarget, randomVector3, RightTarget.transform.rotation);
        }
    }
}
