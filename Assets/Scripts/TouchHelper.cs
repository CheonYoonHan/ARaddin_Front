﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHelper 
{
#if UNITY_EDITOR
    // 유니티 에디터에서 동작하기 위한 코드
    public static bool Touch2 => Input.GetMouseButtonDown(1);
    public static bool IsDown => Input.GetMouseButtonDown(0);
    public static bool IsUp => Input.GetMouseButtonUp(0);
    public static Vector2 TouchPosition => Input.mousePosition;

    // 밑에는 디바이스에서 동작하기 위한 코드
#else
    public static bool Touch2 => Input.touchCount == 2 & (Input.GetTouch(1).phase == TouchPhase.Began);
    public static bool IsDown => Input.GetTouch(0).phase == TouchPhase.Began;
    public static bool IsUp => Input.GetTouch(0).phase == TouchPhase.Ended;
    public static Vector2 TouchPosition => Input.GetTouch(0).position;
#endif
}
