using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Account : MonoBehaviour
{
    // 1. 플레이하면 잔액 0원 남은 것을 표시
    // 2. 플레이하면 제 이름을 표시

    // 추가 작업
    //
    //
    // 3. 버튼을 누르면 인풋박스에 있는 금액만큼 제 계좌에 추가하고 글씨로 표시

    string Name = "김호영";
    int money = 0;

    public Text tName;
    public Text tAmount;
    public Text tReceipt;
    public InputField input;
    public InputField input2;

    void Start()
    {
        tName.text = Name + "님 계좌";
    }

    public void Deposit()
    {
        money = money + int.Parse(input.text);

        Debug.Log(input.text + "원 입금했습니다.");
        tReceipt.text = (input.text + "원 입금했습니다.");

        tAmount.text = money.ToString();
    }

    public void Draw()
    {
        // 잔액 : money
        // 출금금액
        int na = money;
        money = money - int.Parse(input2.text);

        if (money >= 0)
        {
            tReceipt.text = input2.text + "원 출금했습니다";
            tAmount.text = money.ToString();
        }

        else
        {
            tReceipt.text = na + "원 출금했습니다.";


            tAmount.text = "0";
            money = 0;
           
        }
    }
}