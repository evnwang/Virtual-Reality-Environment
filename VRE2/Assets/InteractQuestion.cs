using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class InteractQuestion : MonoBehaviour
{
	public GameObject Canvas;
    public GameObject CanvasText;
    public GameObject CanvasTimer;
    int time;
    int val;
	public float randNum;
	public float randNum2;
    public int index;
    public int index2;
    public float num;
    public float len;
    private Text text;
    int delay;
    int constDelay;
	string[] questions;
	bool reset;
	List<string>ques;
    void Start()
    {
    	ques= new List<string>{"have you seen a stop sign in the past 2 minutes?", "have you seen the office building yet?", "have you seen a fireplace in the past 3 minutes?", "can you see through the water in the fountain?", "have you seen a bridge?", "if you were born in 1997, would you be 23 in 2020?", "are there cars in the garages?", "is every even number divided by an integer even?", "are integers closed under division?", 
                                "is the letter P after the letter Q in the alphabet?", "are all even numbers divided by other even numbers even?", "have you seen the pond in the past 90 seconds?", "are the firehydrants red?", 
                                "is there a plant on any of the park tables?", "is the letter J in the first half of the alphabet?", "a bag has 3 red, 3 blue, and 3 orange marbles. are the chances of you selecting red equal to orange?",
                                "is 3/5 greater than 15/32?", "are stop signs typically hexagons?", "is the g key to the right of the k key on the keyboard?", "is -cosine the inverse of sin?", "is 4 times 4 the same thing as 2 to the power of four?",
                                "is Texas the biggest state in the USA?", "is the brain the largest internal organ of the body?", "is Minneapolis the capital of Minnesota?", "will you be over 26 years old in 2022?", 
                                "have you collected more than 7 balls yet?", "is the b key above the j key on the keyboard?", "is the square root of 2 greater than 1?", "is water wet?", "is 3/4 a gallon greater than 5 pints?", "is one cubic foot of water less than one gallon?",
                                "do infrared waves have a higher frequencey than X-rays?", "were you in 8th grade before the iPhone was invented?"};
		//questions = new string[]{"have you seen a stop sign in the past 2 minutes?", "have you seen the office building yet?", "have you seen a fireplace in the past 3 minutes?", "can you see through the water in the fountain?",
        //                        "have you seen a bridge?", "if you were born in 1997, would you be 23 in 2020?", "are there cars in the garages?", "is every even number divided by an integer even?", "are integers closed under division?", 
        //                        "is the letter P after the letter Q in the alphabet?", "are all even numbers divided by other even numbers even?", "have you seen the pond in the past 90 seconds?", "are the firehydrants red?", 
        //                        "is there a plant on any of the park tables?", "is the letter J in the first half of the alphabet?", "a bag has 3 red, 3 blue, and 3 orange marbles. are the chances of you selecting red equal to orange?",
        //                        "is 3/5 greater than 15/32?", "are stop signs typically hexagons?", "is the g key to the right of the k key on the keyboard?", "is -cosine the inverse of sin?", "is 4 times 4 the same thing as 2 to the power of four?",
        //                        "is Texas the biggest state in the USA?", "is the brain the largest internal organ of the body?", "is Minneapolis the capital of Minnesota?", "will you be over 26 years old in 2022?", 
        //                        "have you collected more than 7 balls yet?", "is the b key above the j key on the keyboard?", "is the square root of 2 greater than 1?", "is water wet?", "is 3/4 a gallon greater than 5 pints?", "is one cubic foot of water less than one gallon?",
        //                        "do infrared waves have a higher frequencey than X-rays?", "were you in 8th grade before the iPhone was invented?"};
    	Canvas = GameObject.Find("Canvas");
    	CanvasTimer=GameObject.Find("CanvasTimer");
        time=0;
        val=5;
        constDelay = 1100;
        delay = 0;
        reset=false;
    }

    void Update() 
    {
        if(time>=3600){
          val=time/3600;
        }
        if(time==0){//deactivate initially    
            Canvas.SetActive(false);
        }
        else if(time%3600==0&&val%2==1){//activate canvas every 2 minutes
            Canvas.SetActive(true);
            CanvasText=Canvas.transform.GetChild(0).gameObject;
            text=CanvasText.GetComponent<Text>();
            //num=(float)questions.Length;
            len=(float)ques.Count;
            //randNum=Random.Range(0,num);
            //index=Mathf.RoundToInt(randNum);
			//text.text=questions[index];
            randNum2=Random.Range(0,len);
            index2=Mathf.RoundToInt(randNum2);
            text.text=ques.ElementAt(index2);
            ques.RemoveAt(index2);

            delay = time;
            CanvasTimer.tag="Untagged";
            reset=true;
        }
        /*else if ((time == (delay + constDelay))  && Canvas.activeSelf){
     		Canvas.SetActive(false);
     	}*/
     	if(CanvasTimer.tag=="Respawn"&&reset){
     		time=1;
     		reset=false;
     	}
     	time++;
    }
}


// 14400 + 900 

