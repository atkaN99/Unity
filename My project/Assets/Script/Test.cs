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
    private string name = "김지원";
    private int age = 27;
    private string mbti = "ISTP";
    private int height = 168;
    private int weight = 75;
    private string bloodType = "A형";
    private string favoriteFood = "돈까스";
    private string hobby = "게임";
    private string favoriteColor = "노란색";
    private string favoriteGame = "메이플스토리";
    private string favoriteMovie = "마블 영화";

//void Start()
//{
//    SelfIntroduction();
//    SelfIntroduction(name, age, mbti, height, weight, bloodType, favoriteFood, hobby, favoriteColor, favoriteGame, favoriteMovie);
//}

//public void SelfIntroduction()
//{
//    Debug.Log("안녕 난 " + name + "야");
//    Debug.Log("나이는 " + age + "살이고 MBTI는 " + mbti + "야");
//    Debug.Log("키는 " + height + "cm이고 몸무게는 " + weight + "kg라구");
//    Debug.Log("혈액형은 " + bloodType + "이야!");
//    Debug.Log("좋아하는 건" + favoriteFood + ", " + favoriteGame + ", " + favoriteMovie + "니 참고해줘");
//}

//public void SelfIntroduction(string name, int age, string mbti, int height, int weight, string bloodType, string favoriteFood, string hobby, string favoriteColor, string favoriteGame, string favoriteMovie)
//{
//    Debug.Log("안녕하세요 " + name + "이에오.");
//    Debug.Log("나이는 " + age + "살이고 MBTI는 " + mbti + "에오.");
//    Debug.Log("키는 " + height + "cm이고 몸무게는 " + weight + "kg에오");
//    Debug.Log("혈액형은 " + bloodType + "에오");
//    Debug.Log("좋아하는 것은" + favoriteFood + ", " + favoriteGame + ", " + favoriteMovie + "에오");
//}







