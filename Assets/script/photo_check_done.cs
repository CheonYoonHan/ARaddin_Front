using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class photo_check_done : MonoBehaviour
{
    public GameObject ok_popup;

    public void ok_btn_click()       //사진 눌러서 팝업창 띄움
    {
        ok_popup.SetActive(true);
    }

    public void yes_btn()    //ok버튼 눌러서 다시사진찍기
    {
        ok_popup.SetActive(false);
        SceneManager.LoadScene("first_nickname_scene");
    }

    public void no_btn()    //no버튼 눌러서 팝업창 닫기
    {
        ok_popup.SetActive(false);
    }
}
