using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main_room : MonoBehaviour  //메인화면에서(방 들어가기전) 방 들어가는 버튼 관리
{
    public InputField input_code;
    public string code;
    public Text alert_text;

    public void mainScene_roomCreateBtn()   //방 만들기 버튼을 눌렀을 때
    {
        SceneManager.LoadScene("room_scene");
    }

    public void mainScene_roomJoinBtn()     //방 들어가기 버튼을 눌렀을 때
    {
        code = input_code.text;             //입력한 코드를 서버에게 주고 알맞은 방으로 가기, 입력코드 유효한지 확인하는 코드 필요

        if (code.Length == 0)   
        {
            alert_text.text = "제대로된 코드를 입력하시오";
        }
        else
        {
            SceneManager.LoadScene("room_scene");
        }
    }
}
