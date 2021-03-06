﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCtrl : MonoBehaviour {

	public string levelNumber;
	public int rotationDirection;
	public Text orange1Txt;
	public Text blue1Txt;
	public Text orange2Txt;
	public Text blue2Txt;
	private int currentLevel;
	private DataController dataController;
	private LevelData levelData;

	void Start () {
		currentLevel = PlayerPrefs.GetInt ("Level", 1);
		dataController = FindObjectOfType<DataController> ();
		levelData = dataController.GetCurrentLevelData (currentLevel);
		fillQuarter ();
	}

	private void fillQuarter(){
		int numbers = levelData.numbers;
		orange1Txt.text = (numbers % 10).ToString ();
		numbers /= 10;
		orange2Txt.text = (numbers % 10).ToString ();
		numbers /= 10;
		blue1Txt.text = (numbers % 10).ToString ();
		numbers /= 10;
		blue2Txt.text = (numbers % 10).ToString ();
	}
}
