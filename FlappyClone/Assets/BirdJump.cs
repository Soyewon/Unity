
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour // Monobehaviour를 상속받는 class Birdjump
{
    Rigidbody2D rb;
    public float jumpPower; // public 변수-Unity 외부에서도 설정 가능하다
    // Start is called before the first frame update
    void Start() // 최초 1번 실행
    {
       // Unity에서 출력할 때 쓰는 함수 Debug.Log
       rb = GetComponent<Rigidbody2D>(); // 꺽쇠 안에 가져올 component의 이름을 넣어줌-rb에 리지드바디의 컴포넌트를 담겠다

    }

    // Update is called once per frame
    void Update() // 매 프레임(1초에 60fps)마다 실행되는 코드 넣는것-1초에 60번마다 실행
    {
        /*화면 터치 시 점프*/
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼을 눌렀을 때
        {
            // 유니티에서는 마우스 클릭이랑 스마트폰 터치랑 같은걸로 취급
            rb.velocity = Vector2.up*jumpPower; // (0,1)*3값만큼 y좌표 방향으로 속도를 갖게됨. Vector2는 2차원 좌표
            

        }
    }

    private void OnCollisionEnter2D(Collision2D other) { // collider끼리 부딪혔을때 실행해라
        if(Score.score > Score.bestScore){
            Score.bestScore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
        
    }
}
