using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter2D(Collider2D other) {
       Score.score++; // score변수를 static으로 지정하였으므로 갖다가 쓸 수 있음
   }
}
