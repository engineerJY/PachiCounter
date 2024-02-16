using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUnderButtons : MonoBehaviour
{
    [SerializeField] private Button button1 = null;
    [SerializeField] private Button button2 = null;
    [SerializeField] private Button button3 = null;

    public Action ChangeMode = null;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(ClickButton1);
        button2.onClick.AddListener(ClickButton2);
        button3.onClick.AddListener(ClickButton3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ClickButton1()
    {
        CommonConst.Instance.SetGameMode(CommonConst.GameMode.Select);
        if (ChangeMode != null)
        {
            ChangeMode();
        }
    }

    private void ClickButton2()
    {
        CommonConst.Instance.SetGameMode(CommonConst.GameMode.Counter);
        if (ChangeMode != null)
        {
            ChangeMode();
        }
    }

    private void ClickButton3()
    {
        CommonConst.Instance.SetGameMode(CommonConst.GameMode.Regist);
        if (ChangeMode != null)
        {
            ChangeMode();
        }
    }
}
