using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour
{

    public GameObject target;
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, new Vector3(0, 0, 1), rotateSpeed * Time.deltaTime);
    }
}
