using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;
    
    public string NextText;
    public void OnClickButton()
    {
          Txt_Text.text = NextText;
    }
    public string NextText2;
    public void OnClickButton2()
    {
         Txt_Text.text = NextText2;
    }
}
    private string name = "������";
    private int age = 27;
    private string mbti = "ISTP";
    private int height = 168;
    private int weight = 75;
    private string bloodType = "A��";
    private string favoriteFood = "���";
    private string hobby = "����";
    private string favoriteColor = "�����";
    private string favoriteGame = "�����ý��丮";
    private string favoriteMovie = "���� ��ȭ";

//void Start()
//{
//    SelfIntroduction();
//    SelfIntroduction(name, age, mbti, height, weight, bloodType, favoriteFood, hobby, favoriteColor, favoriteGame, favoriteMovie);
//}

//public void SelfIntroduction()
//{
//    Debug.Log("�ȳ� �� " + name + "��");
//    Debug.Log("���̴� " + age + "���̰� MBTI�� " + mbti + "��");
//    Debug.Log("Ű�� " + height + "cm�̰� �����Դ� " + weight + "kg��");
//    Debug.Log("�������� " + bloodType + "�̾�!");
//    Debug.Log("�����ϴ� ��" + favoriteFood + ", " + favoriteGame + ", " + favoriteMovie + "�� ��������");
//}

//public void SelfIntroduction(string name, int age, string mbti, int height, int weight, string bloodType, string favoriteFood, string hobby, string favoriteColor, string favoriteGame, string favoriteMovie)
//{
//    Debug.Log("�ȳ��ϼ��� " + name + "�̿���.");
//    Debug.Log("���̴� " + age + "���̰� MBTI�� " + mbti + "����.");
//    Debug.Log("Ű�� " + height + "cm�̰� �����Դ� " + weight + "kg����");
//    Debug.Log("�������� " + bloodType + "����");
//    Debug.Log("�����ϴ� ����" + favoriteFood + ", " + favoriteGame + ", " + favoriteMovie + "����");
//}







