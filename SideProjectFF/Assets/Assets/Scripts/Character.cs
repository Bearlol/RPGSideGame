using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {


    public int baseHealth = 26;
    public int baseStrength = 2;
    public int baseSpeed = 2;
    public int baseTough = 2;
    public Job job;
    
    public int level = 1;
    public int experience = 0;

    public int currentHealth;


   // Use this for initialization
	void Start () {
        baseTough    += job.toughPer * level;
        baseStrength += job.strPer * level;
        baseSpeed    += job.speedPer * level;
        baseHealth += baseTough * 2;
        currentHealth = baseHealth;   
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
    void fixedUpdate()
    {

    }


    
}
