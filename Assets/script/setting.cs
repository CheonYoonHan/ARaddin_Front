using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    public GameObject settingSet;

    public void setting_btn()       //설정버튼 눌러서 팝업창 띄움
    {
        settingSet.SetActive(true);
    }

    public void setting_ok_btn()    //ok버튼 눌러서 팝업창 닫기, 여기에서 설정한 값들 저장하는 것이 필요할 듯
    {
        settingSet.SetActive(false);
    }

}
