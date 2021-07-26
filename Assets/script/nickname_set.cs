using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nickname_set : MonoBehaviour   //user가 입력한 닉네임의 값을 setting
{
    public Text nickname;   //닉네임을 표시할 text

    private void Awake()
    {
        nickname.text = user_nickname.nickname; //text의 값을 닉네임에 저장된 값으로 바꿈
    }
}
