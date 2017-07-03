using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
	private int mp = 53;          // mp

	// magic関数
	public void Magic(int mpsyouhi)
	{//残りmp
		int nokori = this.mp- mpsyouhi;

		//関数の実行内容
		if (nokori < 0)
		{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
		else
		{
			Debug.Log("魔法攻撃をした。残りMPは"+nokori);
		}

	}

}

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Boss Mahou = new Boss();

		for (int i = 1; i <= 11; i++)
		{
			Mahou.Magic(5*i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
