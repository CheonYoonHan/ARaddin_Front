using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting_control_btn : MonoBehaviour    //설정창에서 값 조절하는 버튼들
{
    public Text text_num;
    private int num;
   
    
    public void player_num_minus()
    {
        num = int.Parse(text_num.text);

        if (num - 1 >= 5)
        {
            num -= 1;
            text_num.text = num.ToString();
        }
    }

    public void player_num_plus()
    {
        num = int.Parse(text_num.text);

        if (num + 1 <= 10)
        {
            num += 1;
            text_num.text = num.ToString();
        }
    }

    public void game_time_minus()
    {
        num = int.Parse(text_num.text);

        if (num - 5 >= 15)
        {
            num -= 5;
            text_num.text = num.ToString();
        }
    }

    public void game_time_plus()
    {
        num = int.Parse(text_num.text);

        if (num + 5 <= 30)
        {
            num += 5;
            text_num.text = num.ToString();
        }
    }

    public void treasure_num_minus()
    {
        num = int.Parse(text_num.text);

        if (num - 1 >= 30)
        {
            num -= 1;
            text_num.text = num.ToString();
        }
    }

    public void treasure_num_plus()
    {
        num = int.Parse(text_num.text);

        if (num + 1 <= 40)
        {
            num += 1;
            text_num.text = num.ToString();
        }
    }

}
