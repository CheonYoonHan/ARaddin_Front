using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class photo_retake_pop : MonoBehaviour
{

    public GameObject retry_popup;

    public void photo_click()       //사진 눌러서 팝업창 띄움
    {
        retry_popup.SetActive(true);
    }

    public void retry_ok_btn()    //ok버튼 눌러서 다시사진찍기
    {
        retry_popup.SetActive(false);
        SceneManager.LoadScene("take_photo_scene");
    }

    public void retry_no_btn()    //no버튼 눌러서 팝업창 닫기
    { 
        retry_popup.SetActive(false);
    }
}
