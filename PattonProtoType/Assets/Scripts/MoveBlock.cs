using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{

	bool isRight; // 어떤 방향으로 가는지
	private Transform tr; // transform 변수
	float moveSpeed;
	float orginX;

    // Start is called before the first frame update
    void Start()
    {
		//만든 변수 초기화
		isRight = true;
		tr = this.transform;
		moveSpeed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
		directUpdate(); // 방향을 업데이트 해주는 함수
		move_Block();   // 좌우로 움직이게 해주는 함수
	}

	void move_Block() {
		if (isRight) {  // 오른쪽 방향으로 이동
			tr.Translate(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
		}
		else {          //왼쪽 방향으로 이동
			tr.Translate(-1 * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
		}
	}

	void directUpdate() {
		//좌우로 움직이니까 x 좌표만 받아와서 확인
		float x = tr.transform.position.x;

		if (x < 0){isRight = true;}
		else if (x > 4) { isRight = false; }
	}

	public float getSpeed() {
		return isRight == true ? moveSpeed : -1 * moveSpeed;
	}
}
