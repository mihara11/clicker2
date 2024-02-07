using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int money;
    public Text moneytext;
    public void ButtonClick()
    {
        money++;
    }

    // Update is called once per frame
    void Update()
    {
        moneytext.text = money.ToString();
    }
}
