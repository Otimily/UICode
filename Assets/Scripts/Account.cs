using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Account : MonoBehaviour
{
    // 1. �÷����ϸ� �ܾ� 0�� ���� ���� ǥ��
    // 2. �÷����ϸ� �� �̸��� ǥ��

    // �߰� �۾�
    //
    //
    // 3. ��ư�� ������ ��ǲ�ڽ��� �ִ� �ݾ׸�ŭ �� ���¿� �߰��ϰ� �۾��� ǥ��

    string Name = "��ȣ��";
    int money = 0;

    public Text tName;
    public Text tAmount;
    public Text tReceipt;
    public InputField input;
    public InputField input2;

    void Start()
    {
        tName.text = Name + "�� ����";
    }

    public void Deposit()
    {
        money = money + int.Parse(input.text);

        Debug.Log(input.text + "�� �Ա��߽��ϴ�.");
        tReceipt.text = (input.text + "�� �Ա��߽��ϴ�.");

        tAmount.text = money.ToString();
    }

    public void Draw()
    {
        // �ܾ� : money
        // ��ݱݾ�
        int na = money;
        money = money - int.Parse(input2.text);

        if (money >= 0)
        {
            tReceipt.text = input2.text + "�� ����߽��ϴ�";
            tAmount.text = money.ToString();
        }

        else
        {
            tReceipt.text = na + "�� ����߽��ϴ�.";


            tAmount.text = "0";
            money = 0;
           
        }
    }
}