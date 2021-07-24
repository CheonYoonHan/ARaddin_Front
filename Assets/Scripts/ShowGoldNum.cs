using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGoldNum : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "현재 보유한 보물 개수 0개";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "현재 보유한 보물 개수 " + InventoryController.goldNum + "개";
    }
}
