using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public static HealthManager healthManager;
    public static HealthManager getInstance()
    {
        return healthManager;
    }

    public TextMesh vidaTextKnight;
    public TextMesh vidaTextFox;


    int healthKnight = 42;
    int healthFox = 42;

    private void Awake()
    {
        if (healthManager == null) healthManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (healthManager == null) healthManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void updateHealthKnight(int damage, Animator otherObjectAnimator)
    {
        this.healthKnight -= damage;
        if(this.healthKnight <= 0)
        {
            this.healthKnight = 0;
            otherObjectAnimator.Play("Die");
        }
        this.vidaTextKnight.text = "Vida: " + this.healthKnight;
        
    }

    public void updateHealthFox(int damage, Animator otherObjectAnimator)
    {
        this.healthFox -= damage;
        if (this.healthFox <= 0)
        {
            this.healthFox = 0;
            otherObjectAnimator.Play("Fox_Falling");
        }
        this.vidaTextFox.text = "Vida: " + this.healthFox;
    }

    public bool isDead(string id)
    {
        if(id.Equals("DogPBR"))
        {
            if (this.healthKnight <= 0) return true;
            else return false;
        } else
        {
            if (this.healthFox <= 0) return true;
            else return false;
        }
    }
}
