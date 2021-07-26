using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disap_set : MonoBehaviour
{

    public GameObject cam_btn;

    private void Awake()
    {
        cam_btn.SetActive(icon_disap.icon_state); //text의 값을 닉네임에 저장된 값으로 바꿈
    }
}
