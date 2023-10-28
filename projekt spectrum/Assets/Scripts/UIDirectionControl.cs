using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDirectionControl : MonoBehaviour
{
    private Quaternion relativeRotation;

    void Start()
    {
        relativeRotation = transform.parent.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = relativeRotation;
    }
}
