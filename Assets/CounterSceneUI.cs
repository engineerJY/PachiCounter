using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterSceneUI : SingletonMonoBehaviour<CounterSceneUI>
{
    [SerializeField] private CountUnderButtons underButtons = null;

    [SerializeField] private SelectMode selectMode = null;
    [SerializeField] private CounterMode counterMode = null;
    [SerializeField] private RegistMode registMode = null;
    

    override protected void Awake()
    {
        underButtons.ChangeMode = ChangeGameMode;

        selectMode.Init();
        counterMode.Init();
        registMode.Init();

        CommonConst.Instance.SetGameMode(CommonConst.GameMode.Select);
        ChangeGameMode();
    }

    private void ChangeGameMode()
    {
        switch(CommonConst.Instance.SelectedGameMode)
        {
            case CommonConst.GameMode.Select:
                ChangeModeObj();
                ChangeSelectMode();
                break;
            case CommonConst.GameMode.Counter:
                ChangeModeObj();
                ChangeCounterMode();
                break;
            case CommonConst.GameMode.Regist:
                ChangeModeObj();
                ChangeRegistMode();
                break;
        }
    }

    private void ChangeModeObj()
    {
        selectMode.gameObject.SetActive(CommonConst.Instance.SelectedGameMode == CommonConst.GameMode.Select);
        counterMode.gameObject.SetActive(CommonConst.Instance.SelectedGameMode == CommonConst.GameMode.Counter);
        registMode.gameObject.SetActive(CommonConst.Instance.SelectedGameMode == CommonConst.GameMode.Regist);
    }

    private void ChangeSelectMode()
    {

    }

    private void ChangeCounterMode()
    {

    }

    private void ChangeRegistMode()
    {

    }

    private void OnDestroy()
    {
        
    }
}
