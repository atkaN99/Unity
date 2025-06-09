using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class IF : MonoBehaviour
{
    int count;
    public TextMeshProUGUI printStack;

    public List<string> resultList = new List<string>();

    public Image singleResultImage;                 // 1ȸ �̱�� �̹���
    public Image[] resultImages = new Image[10];    // 10ȸ �̱�� �̹���
    int currentImageIndex = 0;

    public Sprite dia;
    public Sprite gold;
    public Sprite silver;
    public Sprite bronze;
    public Sprite iron;

    private void Awake()
    {
        count = 0;

        resultList.Add("���̾Ƹ��");
        resultList.Add("���");
        resultList.Add("�ǹ�");
        resultList.Add("�����");
        resultList.Add("���̾�");
    }

    public void SingleGacha()
    {
        string result = Gacha();
        printStack.text = $"{count} / 100";

        Sprite resultSprite = GetSpriteForResult(result);
        singleResultImage.sprite = resultSprite;
        singleResultImage.gameObject.SetActive(true);
    }

    public void GatchTen()
    {
        currentImageIndex = 0;

        foreach (var img in resultImages)
        {
            img.gameObject.SetActive(false);
        }

        for (int i = 0; i < 10; i++)
        {
            string result = Gacha();
            printStack.text = $"{count} / 100";

            if (currentImageIndex < resultImages.Length)
            {
                resultImages[currentImageIndex].sprite = GetSpriteForResult(result);
                resultImages[currentImageIndex].gameObject.SetActive(true);
                currentImageIndex++;
            }
        }
    }

    public string Gacha()
    {
        int randomValue = Random.Range(1, 101);
        string result = "";

        if (count >= 100)
        {
            result = resultList[0];
            count = 0;
        }
        else if (randomValue <= 1)
        {
            result = resultList[0];
            count = 0;
        }
        else if (randomValue <= 15)
        {
            result = resultList[1];
            count++;
        }
        else if (randomValue <= 35)
        {
            result = resultList[2];
            count++;
        }
        else if (randomValue <= 65)
        {
            result = resultList[3];
            count++;
        }
        else
        {
            result = resultList[4];
            count++;
        }

        Debug.Log($"���� ��� : {result}");
        return result;
    }

    public Sprite GetSpriteForResult(string result)
    {
        switch (result)
        {
            case "���̾Ƹ��":
                return dia;
            case "���":
                return gold;
            case "�ǹ�":
                return silver;
            case "�����":
                return bronze;
            case "���̾�":
                return iron;
            default:
                return null;
        }
    }
}

//public class IF : MonoBehaviour
//{
//    int count; // count ������ �����Ѵ�
//    public TextMeshProUGUI Txt_text;

//    private void Awake()
//    {
//        count = 0;
//    }



//    public void GatchTen()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Gacha();
//        }
//    }

//    public void GatchTen2()
//    {
//        int num = 0; // 0���� ����
//        while (num < 10)
//        {
//            Gacha();
//            num++;
//        }
//    }

//    public void Gacha()
//    {
//        int randomValue = Random.Range(1, 101); // 1~100

//        Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

//        if (count >= 80)
//        {
//            Debug.Log("Ȯ������ '���̾Ƹ��'�� �̾Ҵ�");
//            count = 0;
//        }
//        else if (randomValue <= 5)
//        {
//            Debug.Log("'���̾Ƹ��'�� �̾Ҵ�");
//            count = 0;
//        }
//        else if (randomValue <= 15)
//        {
//            Debug.Log("'���'�� �̾Ҵ�");
//            count++;
//        }
//        else if (randomValue <= 35)
//        {
//            Debug.Log("'�ǹ�'�� �̾Ҵ�");
//            count++;
//        }
//        else if (randomValue <= 65)
//        {
//            Debug.Log("'�����'�� �̾Ҵ�");
//            count++;
//        }
//        else
//        {
//            Debug.Log("'���̾�'�� �̾ƹ��ȴ�");
//            count++;
//        }
//    }

//    public void GachaSwitch()
//    {
//        int randomValue = Random.Range(1, 101); // 1 ~ 100
//        int selectNumber = 0; // �� ���� �����ؼ� �ٸ� ���̽��� �׽�Ʈ ����

//        switch (selectNumber)
//        {
//            case 0:
//                if (randomValue <= 10)
//                {
//                    Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
//                }
//                else if (randomValue <= 30)
//                {
//                    Debug.Log("'��'�� �̾Ҵ�!");
//                }
//                else
//                {
//                    Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
//                }
//                break;

//            case 1:
//                if (randomValue <= 10)
//                {
//                    Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
//                }
//                else if (randomValue <= 30)
//                {
//                    Debug.Log("'��'�� �̾Ҵ�!");
//                }
//                else
//                {
//                    Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
//                }
//                break;

//            case 2:
//                if (randomValue <= 10)
//                {
//                    Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
//                }
//                else if (randomValue <= 30)
//                {
//                    Debug.Log("'��'�� �̾Ҵ�!");
//                }
//                else
//                {
//                    Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
//                }
//                break;

//            default:
//                if (randomValue <= 10)
//                {
//                    Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
//                }
//                else if (randomValue <= 30)
//                {
//                    Debug.Log("'��'�� �̾Ҵ�!");
//                }
//                else
//                {
//                    Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
//                }
//                break;
//        }
//    }
//}
