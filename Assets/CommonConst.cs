using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonConst : SingletonMonoBehaviour<CommonConst>
{
    override protected void Awake()
    {
        Debug.Log("CommonConst Awake");

        foreach(var ar in DropDownArray)
        {
            DropDownList.Add(ar);
        }
    }

    public enum GameMode
    {
        Select = 0,
        Counter = 1,
        Regist = 2
    }

    public List<string> DropDownList = new List<string>();
    public string[] DropDownArray = new string[] { "Bell", "Replay", "Suika1", "Suika2", "Cherry1", "Cherry2", "Chanse1", "Chanse2" };

    public CommonConst.GameMode SelectedGameMode { get; private set; }
    public void SetGameMode(CommonConst.GameMode gameMode)
    {
        SelectedGameMode = gameMode;
        /*if(action != null)
        {
            action();
        }*/
    }

}
