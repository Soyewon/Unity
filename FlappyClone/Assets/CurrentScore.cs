using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Score: " + Score.score.ToString(); // 현재 점수를 반영하기 위함. 한번만 반영하면 되므로 start에 넣어줌
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
