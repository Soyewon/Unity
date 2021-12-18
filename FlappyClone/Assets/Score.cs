using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UnityEngine의 UI를 가져와서 할 때

public class Score : MonoBehaviour
{
    // static 변수 : instance 생성 없이 클래스 단위로 관리해 주기 위해서 사용. 클래스 외부에서도 클래스에 접근해서 해당 변수 조작 가능
    public static int score = 0; 
     public static int bestScore = 0; 
    // Start is called before the first frame update
    void Start()
    {
        score = 0; // score점수 초기화
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
}
