using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldController : MonoBehaviour
{
    public float positionY = 0.4f;
    public GameObject[] prefab;

    private Camera mainCamera;
    private GameObject HoldingObject;
    private Vector3 InputPosition;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
#if !UNITY_EDITOR
        if (Input.touchCount == 0) return;
#endif
        InputPosition = TouchHelper.TouchPosition;

        if (!TouchHelper.IsDown) return;

        if (Physics.Raycast(mainCamera.ScreenPointToRay(InputPosition), out var hits, mainCamera.farClipPlane))
        {
            if (hits.transform.gameObject.tag.Equals("Gold"))   // 터치한 오브젝트의 Tag가 Gold라면
            {
                HoldingObject = hits.transform.gameObject;
                if (InventoryController.goldNum < 3)    // 인벤토리에 여유 공간이 있다면
                {
                    InventoryController.goldNum++;  // 인벤토리 보물 개수 증가 
                    //Destroy(HoldingObject);   // 보물 오브젝트 파괴 -> 사용X 
                    HoldingObject.SetActive(false); // 보물 오브젝트 비활성화
                    HoldingObject = null;
                }
                else
                {
                    HoldingObject = null;
                }
            }
        }
    }
}
