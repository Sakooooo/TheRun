using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyThing : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0, 0, -0.05f);
    }
}
