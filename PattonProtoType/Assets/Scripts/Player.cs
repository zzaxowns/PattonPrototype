using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	MoveBlock block = GameObject.Find("Block").GetComponent<MoveBlock>();

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(block.getSpeed());
		Debug.Log("HI");
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.transform.CompareTag("MoveBlock"))
		{
			float speed = block.getSpeed();
			this.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
			Debug.Log("충돌");
		}
	}
}
