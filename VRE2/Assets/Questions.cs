using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
	private GameObject Canvas;
    private GameObject CanvasText;
    private GameObject CanvasEnabler;
    private GameObject wall;
    private int time;
    private int val;
	private float randNum;
    private int index;
    private float num;
    private Text text;
    int delay;
    int constDelay;
	private string[] questions;
    // Start is called before the first frame update
    /*void Start()
    {
    // const float popupDelay = 3f; 
    	questions = new string[]{"have you seen a stop sign in the past 2 minutes?", "have you seen the office building yet?", "have you seen a fireplace in the past 3 minutes?", "can you see through the water in the fountain?",
                                "have you seen a bridge?", "if you were born in 1997, would you be 23 in 2020?", "are there cars in the garages?", "is every even number divided by an integer even?", "are integers closed under division?", 
                                "is the letter P after the letter Q in the alphabet?", "are all even numbers divided by other even numbers even?", "have you seen the pond in the past 90 seconds?", "are the firehydrants red?", 
                                "is there a plant on any of the park tables?", "is the letter J in the first half of the alphabet?", "a bag has 3 red, 3 blue, and 3 orange marbles. are the chances of you selecting red equal to orange?",
                                "is 3/5 greater than 15/32?", "are stop signs typically hexagons?", "on a keyboard, is the g key on the right of the k key?", "is -cosine the inverse of sin?", "is 4 times 4 the same thing as 2 to the power of four?",
                                "is Texas the biggest state in the USA?", "is the brain the largest internal organ of the body?", "is the capital of Minnesota Minneapolis?", "will you be over 26 years old in 2022?", 
                                "have you collected more than 7 balls yet?", "is the b key above the j key on the keyboard?", "is the square root of 2 greater than 1?", "is water wet?", "is 3/4 a gallon greater than 5 pints?", "is one cubic foot of water less than one gallon?",
                                "do infrared waves have a higher frequencey than X-rays?", "were you in 8th grade before the iPhone was invented?"};
    	Canvas = GameObject.Find("Canvas");
        time=0;
        val=5;
        constDelay = 1100;
        delay = 0;
        CanvasEnabler=GameObject.Find("CanvasEnabler");
        wall=GameObject.Find("Demo Wall");
    }

    // Update is called once per frame
    void Update() 
    {
        if(time>=3600){
          val=time/3600;

        }
        if(time==0){    
            Canvas.SetActive(false);
        }
        //else if(timeS%14400==0){//scale canvas
        // else if(time%1800==0&&val%4==0){//scale canvas
        //     Debug.Log("Scale:"+time);
        //     Debug.Log("Val: "+val);
        //     Canvas.SetActive(true);
        //     CanvasText=Canvas.transform.GetChild(0).gameObject;
        //     text=CanvasText.GetComponent<Text>();
        //     text.text="scale";
        //     delay = time;
        // }
        //else if(timeQ%7200==0){//question canvas
        else if(time%3600==0&&val%2==1){//question canvas
            //Debug.Log("Question:"+time);
            //Debug.Log("Val: "+val);
            Canvas.SetActive(true);
            CanvasText=Canvas.transform.GetChild(0).gameObject;
            text=CanvasText.GetComponent<Text>();
            num=(float)questions.Length;
            randNum=Random.Range(0,num);
            index=Mathf.RoundToInt(randNum);
            text.text=questions[index];
            delay = time;
        }
    	//else if ((timeS%14400==900 && Canvas.activeSelf) || (timeQ%7200==900 && Canvas.activeSelf)){
        else if ((time == (delay + constDelay))  && Canvas.activeSelf){
            //Debug.Log("deactivate canvas "+time);
     		Canvas.SetActive(false);
     	}
     	time++;
        //Debug.Log("Time:"+time);
    }*/
}


// 14400 + 900 
