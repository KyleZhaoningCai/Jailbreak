﻿/* Source File Name: PushBall3.cs
 * Author's Name: Zhaoning Cai
 * Last Modified on: Dec 4, 2015
 * Program Description: Third Person Stealth Game. Player escapes the dungeon to win
 * the level. The player needs to solve puzzles and avoid/deactivate enemies
 * Revision History: Final Version
 */
using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

public class PushBall3 : MonoBehaviour {

	public GameObject Fallen;
	public GameController gameController;

	
	// Update is called once per frame
	void Update(){
		if (this.gameController._Move3){
			Destroy (this.gameObject);
			Instantiate(Fallen, this.transform.position, this.transform.rotation);
		}

	}
}
