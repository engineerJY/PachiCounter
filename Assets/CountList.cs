using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountList : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown = null;
    [SerializeField] private TextMeshProUGUI countNum = null;
    [SerializeField] private Button buttonPlus = null;
    [SerializeField] private Button buttonMinus = null;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        buttonPlus.onClick.AddListener(ClickCountPlusButton);
        buttonMinus.onClick.AddListener(ClickCountMinusButton);
        count = 0;
        SetCountNumText(count);


        dropdown.ClearOptions();
        dropdown.AddOptions(CommonConst.Instance.DropDownList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ClickCountPlusButton()
    {
        count++;
        SetCountNumText(count);
    }

    private void ClickCountMinusButton()
    {
        count--;
        SetCountNumText(count);
    }

    private void SetCountNumText(int num)
    {
        countNum.text = num.ToString();
    }
}
