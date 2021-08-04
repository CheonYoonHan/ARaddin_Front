using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sheriff_SafeController : MonoBehaviour
{
    public static int savedGoldNum;  // 금고에 소유한 보물 개수 -> 통신 할 때 서버에서 받아오는걸로 수정

    [SerializeField]
    Text text;

    [SerializeField]
    Slider slider;

    private Vector3 InputPosition;
    private Camera mainCamera;


    void Start()
    {
        savedGoldNum = 0;   // 금고에 저장된 보물 개수 초기화
    }

    void Update()
    {
        text.text = savedGoldNum + "/30";   // 금고 보물 개수 업데이트
        setGoldGauge();

        InputPosition = TouchHelper.TouchPosition;

        if (!TouchHelper.IsDown) return;

        if (Physics.Raycast(mainCamera.ScreenPointToRay(InputPosition), out var hits, mainCamera.farClipPlane))
        {
            if (hits.transform.gameObject.tag.Equals("Chest"))   // 터치한 오브젝트의 Tag가 Chest라면
            {
                // placedGoldNum += savedGoldNum // 바닥에 있는 보물의 개수를 금고에 저장되어 있던 보물 개수만큼 증가
                savedGoldNum = 0;
            }
        }
    }

    void setGoldGauge()
    {
        slider.value = savedGoldNum;
    }
}
