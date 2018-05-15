using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
    int guess;
   
    public int maxGuessesAllowed = 7;
    
    public Text text;

	void Start () {
		StartGame();
	}

	void StartGame (){
        
		min = 1;
		max = 1001;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

	void NextGuess(){
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
        else
        {
            guess = Random.Range(min, max + 1);
            text.text = guess.ToString();
        }

	}
}
