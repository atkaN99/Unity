using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class HP : MonoBehaviour
{
    public Image Img_HPbar;
    public TextMeshProUGUI Txt_HP; // HP 텍스트 UI 요소
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
    public void OnClickDamage() //데미지

    {
        nowHP -= Damage;
        if (nowHP < 0)
        {
            nowHP = 0;
        }
        Img_HPbar.fillAmount = nowHP / maxHP; // HP 업데이트
        Txt_text.text = $"{Damage}의 데미지를 입었다"; // HP 텍스트 업데이트
        RefrshUI();
    }
    public void OnClickHeal() //회복
    {
        nowHP += HealPoint;
        if (nowHP > maxHP)
        {
            nowHP = maxHP;
        }
        Img_HPbar.fillAmount = nowHP / maxHP; // HP 업데이트
        Txt_text.text = $"{HealPoint}의 데미지를 회복했다";
        RefrshUI();
    }
    void RefrshUI()
    {
        Img_HPbar.fillAmount = nowHP / maxHP; // HP 업데이트
        Txt_HP.text = $"{nowHP} / {maxHP}"; // HP 텍스트 업데이트
    }
} 

