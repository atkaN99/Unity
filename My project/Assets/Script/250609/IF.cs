using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class IF : MonoBehaviour
{
    int count;
    public TextMeshProUGUI printStack;

    public List<string> resultList = new List<string>();

    public Image singleResultImage;                 // 1회 뽑기용 이미지
    public Image[] resultImages = new Image[10];    // 10회 뽑기용 이미지
    int currentImageIndex = 0;

    public Sprite dia;
    public Sprite gold;
    public Sprite silver;
    public Sprite bronze;
    public Sprite iron;

    private void Awake()
    {
        count = 0;

        resultList.Add("다이아몬드");
        resultList.Add("골드");
        resultList.Add("실버");
        resultList.Add("브론즈");
        resultList.Add("아이언");
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

        Debug.Log($"뽑은 결과 : {result}");
        return result;
    }

    public Sprite GetSpriteForResult(string result)
    {
        switch (result)
        {
            case "다이아몬드":
                return dia;
            case "골드":
                return gold;
            case "실버":
                return silver;
            case "브론즈":
                return bronze;
            case "아이언":
                return iron;
            default:
                return null;
        }
    }
}

//public class IF : MonoBehaviour
//{
//    int count; // count 변수를 선언한다
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
//        int num = 0; // 0부터 시작
//        while (num < 10)
//        {
//            Gacha();
//            num++;
//        }
//    }

//    public void Gacha()
//    {
//        int randomValue = Random.Range(1, 101); // 1~100

//        Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");

//        if (count >= 80)
//        {
//            Debug.Log("확정으로 '다이아몬드'를 뽑았다");
//            count = 0;
//        }
//        else if (randomValue <= 5)
//        {
//            Debug.Log("'다이아몬드'를 뽑았다");
//            count = 0;
//        }
//        else if (randomValue <= 15)
//        {
//            Debug.Log("'골드'를 뽑았다");
//            count++;
//        }
//        else if (randomValue <= 35)
//        {
//            Debug.Log("'실버'를 뽑았다");
//            count++;
//        }
//        else if (randomValue <= 65)
//        {
//            Debug.Log("'브론즈'를 뽑았다");
//            count++;
//        }
//        else
//        {
//            Debug.Log("'아이언'을 뽑아버렸다");
//            count++;
//        }
//    }

//    public void GachaSwitch()
//    {
//        int randomValue = Random.Range(1, 101); // 1 ~ 100
//        int selectNumber = 0; // 이 값을 변경해서 다른 케이스로 테스트 가능

//        switch (selectNumber)
//        {
//            case 0:
//                if (randomValue <= 10)
//                {
//                    Debug.Log("'은색 머리'을 뽑았다!");
//                }
//                else if (randomValue <= 30)
//                {
//                    Debug.Log("'모나'을 뽑았다!");
//                }
//                else
//                {
//                    Debug.Log("'치치'를 뽑아버렸다!");
//                }
//                break;

//            case 1:
//                if (randomValue <= 10)
//                {
//                    Debug.Log("'파란 머리'을 뽑았다!");
//                }
//                else if (randomValue <= 30)
//                {
//                    Debug.Log("'모나'을 뽑았다!");
//                }
//                else
//                {
//                    Debug.Log("'치치'를 뽑아버렸다!");
//                }
//                break;

//            case 2:
//                if (randomValue <= 10)
//                {
//                    Debug.Log("'분홍 머리'을 뽑았다!");
//                }
//                else if (randomValue <= 30)
//                {
//                    Debug.Log("'모나'을 뽑았다!");
//                }
//                else
//                {
//                    Debug.Log("'치치'를 뽑아버렸다!");
//                }
//                break;

//            default:
//                if (randomValue <= 10)
//                {
//                    Debug.Log("'파란 머리 꼬마'을 뽑았다!");
//                }
//                else if (randomValue <= 30)
//                {
//                    Debug.Log("'모나'을 뽑았다!");
//                }
//                else
//                {
//                    Debug.Log("'치치'를 뽑아버렸다!");
//                }
//                break;
//        }
//    }
//}
