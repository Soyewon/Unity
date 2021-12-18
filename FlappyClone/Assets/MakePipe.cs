using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe; // Pipe prefab을 GameObject로 가져옴
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // timer가 1이 된다는것 = 프레임만큼 실행된것
        
        if(timer>timeDiff)// 1보다 크면 어떤 fps든 간에 1초가 흐른 시점
        { 
            GameObject newpipe = Instantiate(pipe); // pipe를 매 프레임마다 찍어내도록 하는 함수 Instantiate();

            /* Gameobject로 새로 생기는 파이프들을 newpipe로 받아서, transform.position을 이용해 위치를 수정해줌*/
            newpipe.transform.position = new Vector3(5,Random.Range(-2.0f,5.0f),0); 
            timer = 0;
            Destroy(newpipe, 10.0f); // 메모리를 차지하므로 만들어진 파이프가 10초 후에 사라지도록 함
        }
        
    }
}
