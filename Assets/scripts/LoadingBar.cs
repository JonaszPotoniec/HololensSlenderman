using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour {

    public Transform LoadingBarr;
    public Transform Text;
    public float currentAmount;
    public float speed;
    private GameObject usedBy;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(currentAmount < 1)
        {
            currentAmount += speed * Time.deltaTime;
            Text.GetComponent<Text>().text = (Mathf.Round(currentAmount*100)).ToString() + "%";
        }
        else
        {
            LoadingBarr.gameObject.SetActive(false);
            Text.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            if(usedBy != null)
                usedBy.SendMessageUpwards("countingDone");
        }
        LoadingBarr.GetComponent<Image>().fillAmount = currentAmount;

	}

    void Play(float newSpeed, GameObject back)
    {
        usedBy = back;
        speed = newSpeed; 
        LoadingBarr.gameObject.SetActive(true);
        Text.gameObject.SetActive(true);
        this.gameObject.SetActive(true);
        currentAmount = 0;
    }
}
