using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_disap : MonoBehaviour
{
    public bool state;
    public static bool icon_state;

    void Update()
    {
        icon_state = state;
    }
}
