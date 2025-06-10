using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Star : MonoBehaviour
{
    string star;
    public TextMeshProUGUI starText;

    //star += "��"; // ��
    //star += "   "; // ��ĭ
    //star += "\n"; // �ٹٲ�

    //i : �� ��
    //j : ���� / ���� ����


    void Start()
    {

    }
    public void Phase1()
    {
        star = string.Empty; // 1������ �ʱ�ȭ�ܰ�
        int line = 5; //���� 5��

        for (int i = 0; i < line; i++) // i(�� ��)�� line���� ���� �� i�� ��� ����
        {

            for (int j = 0; j < i + 1; j++) //j(���� ����)�� 0���� ����, j(���� ����)�� i(�� ��)���� ���� �� ��� ����
            {
                star += "��";
            }

            star += "\n";
        }
        Debug.Log(star);
        starText.text = star;

    }
    public void Phase2()
    {
        star = string.Empty; // 2��
        int line = 5;

        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "   ";
            }

            for (int j = 0; j < line - i; j++)
            {
                star += "��";
            }

            star += "\n";
        }
        Debug.Log(star);
        starText.text = star;
    }
    public void Phase3()
    {
        star = string.Empty; // 3��
        int line = 5;

        for (int i = 1; i <= line; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "��";
            }
            star += "\n";
        }

        for (int i = line - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                star += "��";
            }
            star += "\n";
        }

        Debug.Log(star);
        starText.text = star;
    }
    public void Phase4()
    {
        star = string.Empty; // 4��
        int line = 5;

        for (int i = 1; i <= line; i++)
        {
            for (int j = 0; j < line - i; j++)
            {
                star += "   ";
            }
            for (int j = 0; j < i; j++)
            {
                star += "��";
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
                star += "��";
            }
            star += "\n";
        }

        Debug.Log(star);
        starText.text = star;
    }
    public void Phase5()
    {
        star = string.Empty;    // 5��
        int line = 9;

        for (int i = 0; i < line; i++)
        {

            for (int j = 0; j < ((i < line / 2) ? (line / 2 - i) : (i - line / 2)); j++)
            {
                star += "   ";
            }

            for (int j = 0; j < (line - (((i < line / 2) ? (line / 2 - i) : (i - line / 2)) * 2)); j++)
            {
                star += "��";
            }

            star += "\n";
        }

        Debug.Log(star);
        starText.text = star;
    }
}


