﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{ private int mp = 53;
	// magic関数
	public void Magic(){
		
		//関数の実行内容
		if (this.mp>= 5)
		{
			mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
		}
		else
		{
			Debug.Log("MPが足りないため魔法が使えない。");
		}

	}
}

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Boss Mahou = new Boss();

		for (int i = 1; i <= 11; i++)
		{
			Mahou.Magic();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
