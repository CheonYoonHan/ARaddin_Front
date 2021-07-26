using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class user_nickname : MonoBehaviour
{
    public InputField input;    //입력받는 input field
    public static string nickname;  //input field에 입력한 값을 저장할 곳

    void Update()
    {
        nickname = input.text; //input field에 user가 입력한 닉네임을 저장
    }
}
