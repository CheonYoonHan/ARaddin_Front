using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeController : MonoBehaviour
{
    public static int savedGoldNum;  // 금고에 소유한 보물 개수

    // Theif
    [SerializeField]
    Text text1;

    [SerializeField]
    Slider slider1;

    // Sheriff
    [SerializeField]
    Text text2;

    [SerializeField]
    Slider slider2;

    private Vector3 InputPosition;

    void Start()
    {
        savedGoldNum = 0;   // 금고에 저장된 보물 개수 초기화
    }

    void Update()
    {
        text1.text = savedGoldNum + "/30";   // 금고 보물 개수 업데이트
        text2.text = savedGoldNum + "/30";   // 금고 보물 개수 업데이트
        setGoldGauge();

        InputPosition = TouchHelper.TouchPosition;

        if (!UserPanelController.state)
        {
            

            //if (!TouchHelper.IsDown) return;

            //if (Physics.Raycast(mainCamera.ScreenPointToRay(InputPosition), out var hits, mainCamera.farClipPlane))
            //{
            //    if (hits.transform.gameObject.tag.Equals("Gold"))   // 터치한 오브젝트의 Tag가 Gold라면
            //    {
            //        HoldingObject = hits.transform.gameObject;
            //        if (InventoryController.goldNum < 3)    // 인벤토리에 여유 공간이 있다면
            //        {
            //            InventoryController.goldNum++;  // 인벤토리 보물 개수 증가 
            //                                            //Destroy(HoldingObject);   // 보물 오브젝트 파괴 -> 사용X 
            //            HoldingObject.SetActive(false); // 보물 오브젝트 비활성화
            //            HoldingObject = null;
            //        }
            //        else
            //        {
            //            HoldingObject = null;
            //        }
            //    }
            //}
        }
    }

    void setGoldGauge()
    {
        slider1.value = savedGoldNum;
        slider2.value = savedGoldNum;
    }
}
