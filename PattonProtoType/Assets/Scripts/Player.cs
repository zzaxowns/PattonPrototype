using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	MoveBlock block;

    // Start is called before the first frame update
    void Start()
    {
		block = GameObject.Find("Block").GetComponent<MoveBlock>(); 
	}

    // Update is called once per frame
    void Update()
    {
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.transform.tag == "MoveBlock")
		{
			float speed = block.getSpeed();
			this.transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
			Debug.Log("충돌");
		}
	}
}
