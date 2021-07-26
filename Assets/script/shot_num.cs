using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_num : MonoBehaviour
{
    public int num;
    public static int shot_number;

    void Update()
    {
        shot_number = num;
    }
}
