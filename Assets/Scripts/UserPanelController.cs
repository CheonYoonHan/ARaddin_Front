using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserPanelController : MonoBehaviour
{
    public static bool state = false;

    [SerializeField]
    GameObject ThiefPanel;

    [SerializeField]
    GameObject SheriffPanel;

    [SerializeField]
    Button btn;

    [SerializeField]
    Text text;

    void Start()
    {
        
    }

    void Update()
    {
        if (state)
        {
            text.text = "Thief";
            ThiefPanel.SetActive(true);
        }
        else
        {
            text.text = "Sheriff";
            SheriffPanel.SetActive(true);
        }
    }

    void ChangeState()
    {
        state = !state;
    }
}
