using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{
    public Vector3 vec3;

    void Start()
    {
        vec3 = new Vector3 (0, -3.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vec3);
    }
}
