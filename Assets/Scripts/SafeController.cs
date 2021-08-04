using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeController : MonoBehaviour
{
    public static int savedGoldNum;  // 금고에 소유한 보물 개수 -> 통신 할 때 서버에서 받아오는걸로 수정

    [SerializeField]
    Text text;

    [SerializeField]
    Slider slider;

    void Start()
    {
        savedGoldNum = 0;   // 금고에 저장된 보물 개수 초기화
    }

    void Update()
    {
        text.text = savedGoldNum + "/30";   // 금고 보물 개수 업데이트
        setGoldGauge();  
    }

    void setGoldGauge()
    {
        slider.value = savedGoldNum;
    }
}
