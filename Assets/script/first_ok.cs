using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class first_ok : MonoBehaviour   // 첫 화면에서 닉네임 작성후 ok버튼 누르기
{
    private InputField input_nickname;
    public Text alert_text;

   public void firstScene_okbtn()   //닉네임의 길이와 카메라 인식여부 확인되어야함
    {
        if (user_nickname.nickname.Length == 0)
        {
            alert_text.text = "닉네임은 적어도 한글자 이상이어야 합니다.";
        }
        else
        {
            SceneManager.LoadScene("main_scene");
        }
    }

}
