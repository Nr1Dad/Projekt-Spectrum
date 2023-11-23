using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorreLayer : MonoBehaviour
{
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 6);
    }
}
