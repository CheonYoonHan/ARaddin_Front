using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    //public Button button;
    [SerializeField]
    Text inventoryGoldNumText;   // 인벤토리에 저장된 보물 개수 텍스트

    [SerializeField]
    Text selectGoldNumText;  // 저장할 보물 개수 텍스트

    [SerializeField]
    Text guideText;  // 보물을 몇개 저장할거냐는 문구

    [SerializeField]
    GameObject saveGoldPanel;    // 보물을 몇개 저장할건지 묻는 패널

    public static int goldNum;  // 인벤토리에 소유한 보물 개수

    private int tmp;

    void Start()
    {
        goldNum = 0;
        inventoryGoldNumText.text = "0";    // 인벤토리에 저장된 보물 개수 텍스트 초기화
        selectGoldNumText.text = "0";   // 저장할 보물 개수 텍스트 초기화
        guideText.text = "몇 개의 보물을 저장하시겠습니까?";
    }

    void Update()
    {
        inventoryGoldNumText.text = goldNum + "/3"; // 인벤토리에 저장된 보물 개수 업데이트
        if (!ChestOpenAnimation.isPlayerEnter)  // 유저가 chest의 boxcollider 범위 내에 있지 않다면
        {
            saveGoldPanel.SetActive(false); // 패널 비활성화
        }
    }

    public void PlusSaveGoldNum()   // 저장할 보물 개수 조절 버튼 중 +버튼
    {
        tmp = int.Parse(selectGoldNumText.text);
        if(tmp < goldNum)   // 인벤토리 내의 보물 개수(유저가 현재 소유한 보물 개수)가 최대값
        {
            selectGoldNumText.text = (tmp + 1).ToString();
        }  
    }

    public void MinusSaveGoldNum()  // 저장할 보물 개수 조절 버튼 중 -버튼
    {
        tmp = int.Parse(selectGoldNumText.text);  
        if (tmp > 0)
        {
            selectGoldNumText.text = (tmp - 1).ToString();
        }
    }

    public void SaveGold()  // 금고에 보물 저장 버튼
    {
        tmp = int.Parse(selectGoldNumText.text);
        SafeController.savedGoldNum += tmp; // 금고에 저장된 보물 개수 증가
        goldNum -= tmp; // 인벤토리의 보물 개수 감소 
        selectGoldNumText.text = "0";   // 보물 개수 선택 텍스트 초기화 
        saveGoldPanel.SetActive(false); // 패널 비활성화
    }

    public void Cancel()    // 취소 버튼(보물 저장 안함)
    {
        selectGoldNumText.text = "0";   // 보물 개수 선택 텍스트 초기화 
        saveGoldPanel.SetActive(false); // 패널 비활성화
    }

    public void InventoryButton()   // 인벤토리 버튼
    {
        if (ChestOpenAnimation.isPlayerEnter)   // 유저가 chest의 boxcollider 범위 내에 있다면
        {
            saveGoldPanel.SetActive(true);  // 인벤토리 버튼을 눌렀을 때 보물 저장 패널 활성화 가능
        }  
    }
}
