using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class HP : MonoBehaviour
{
    public Image Img_HPbar;
    public TextMeshProUGUI Txt_HP; // HP �ؽ�Ʈ UI ���
    public TextMeshProUGUI Txt_text;

    public int maxHP;
    float nowHP;

    public int Damage;
    public int HealPoint;

    void Awake()
    {
        nowHP = maxHP;
        Initialize();

        void Initialize() // Initialize()
        {
            RefrshUI();
        }
    }
    public void OnClickDamage() //������

    {
        nowHP -= Damage;
        if (nowHP < 0)
        {
            nowHP = 0;
        }
        Img_HPbar.fillAmount = nowHP / maxHP; // HP ������Ʈ
        Txt_text.text = $"{Damage}�� �������� �Ծ���"; // HP �ؽ�Ʈ ������Ʈ
        RefrshUI();
    }
    public void OnClickHeal() //ȸ��
    {
        nowHP += HealPoint;
        if (nowHP > maxHP)
        {
            nowHP = maxHP;
        }
        Img_HPbar.fillAmount = nowHP / maxHP; // HP ������Ʈ
        Txt_text.text = $"{HealPoint}�� �������� ȸ���ߴ�";
        RefrshUI();
    }
    void RefrshUI()
    {
        Img_HPbar.fillAmount = nowHP / maxHP; // HP ������Ʈ
        Txt_HP.text = $"{nowHP} / {maxHP}"; // HP �ؽ�Ʈ ������Ʈ
    }
} 

