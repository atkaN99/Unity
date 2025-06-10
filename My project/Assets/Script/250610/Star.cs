using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Star : MonoBehaviour
{
    string star;
    public TextMeshProUGUI starText;

    //star += "★"; // 별
    //star += "   "; // 빈칸
    //star += "\n"; // 줄바꿈

    //i : 줄 수
    //j : 공백 / 별의 개수


    void Start()
    {

    }
    public void Phase1()
    {
        star = string.Empty; // 1페이즈 초기화단계
        int line = 5; //줄은 5줄

        for (int i = 0; i < line; i++) // i(줄 수)이 line보다 작을 때 i는 계속 증가
        {

            for (int j = 0; j < i + 1; j++) //j(별의 개수)는 0부터 시작, j(별의 개수)는 i(줄 수)보다 작을 때 계속 증가
            {
                star += "★";
            }

            star += "\n";
        }
        Debug.Log(star);
        starText.text = star;

    }
    public void Phase2()
    {
        star = string.Empty; // 2페
        int line = 5;

        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "   ";
            }

            for (int j = 0; j < line - i; j++)
            {
                star += "★";
            }

            star += "\n";
        }
        Debug.Log(star);
        starText.text = star;
    }
    public void Phase3()
    {
        star = string.Empty; // 3페
        int line = 5;

        for (int i = 1; i <= line; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        for (int i = line - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
        starText.text = star;
    }
    public void Phase4()
    {
        star = string.Empty; // 4페
        int line = 5;

        for (int i = 1; i <= line; i++)
        {
            for (int j = 0; j < line - i; j++)
            {
                star += "   ";
            }
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }
        for (int i = line - 1; i >= 1; i--)
        {
            for (int j = 0; j < line - i; j++)
            {
                star += "   ";
            }
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        Debug.Log(star);
        starText.text = star;
    }
    public void Phase5()
    {
        star = string.Empty;    // 5페
        int line = 9;

        for (int i = 0; i < line; i++)
        {

            for (int j = 0; j < ((i < line / 2) ? (line / 2 - i) : (i - line / 2)); j++)
            {
                star += "   ";
            }

            for (int j = 0; j < (line - (((i < line / 2) ? (line / 2 - i) : (i - line / 2)) * 2)); j++)
            {
                star += "★";
            }

            star += "\n";
        }

        Debug.Log(star);
        starText.text = star;
    }
}


