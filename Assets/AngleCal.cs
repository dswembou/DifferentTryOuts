using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCal : MonoBehaviour
{
    [SerializeField] private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate1();
        Calculate2();
    }

    void Calculate1()
    {
        Vector3 targetDir = target.position - transform.position;
        print(targetDir);
        Vector3 forward = transform.forward;

        float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);

        print("Angle : " + angle);
    }
    
    void Calculate2()
    {
        Vector3 targetDir = transform.position - target.position;
        //print(targetDir);
        Vector3 forward = target.forward;

        float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);

        print("Angle : " + angle);
    }
}
