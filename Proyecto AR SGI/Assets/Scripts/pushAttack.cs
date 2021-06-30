using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushAttack : MonoBehaviour
{
    public Material hitMaterial;
    public Material origMaterial;
    public GameObject buttonBG;


    private Animator animator;
    private GameObject personaje;

    private Animator otherObjectAnimator;// Workaround, could be done a lot better

    public int damage = 5;

    public string objectID;
    public string animationName;
    public bool isFox;

    public string otherObjectID;

    // Start is called before the first frame update
    void Start()
    {
        if (isFox)
        {
            objectID = "Fox";
            animationName = "Fox_Attack_Paws";
            otherObjectID = "DogPBR";
        } else
        {
            objectID = "DogPBR";
            animationName = "Attack01";
            otherObjectID = "Fox";
        }
        this.personaje = GameObject.Find(objectID);
        this.animator = personaje.GetComponent<Animator>();

        GameObject otherPersonaje = GameObject.Find(objectID.Equals("Fox")? "DogPBR":"Fox");
        this.otherObjectAnimator = otherPersonaje.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                var rig = hitInfo.collider.GetComponent<Rigidbody>();
                if (rig != null && rig == buttonBG.GetComponent<Rigidbody>())
                {
                    rig.GetComponent<MeshRenderer>().material = hitMaterial;
                    //yield return new WaitForSeconds(.1f);
                    //rig.GetComponent<MeshRenderer>().material = origMaterial;
                    // Acción de atacar
                    /*
                    if (tag = zorro y atacar)

                            zorro tenga animamcion atacar
                        baja untuacion caballero
                    */


                    //play audio has ganado

            /*    }

            }
        }*/
    }

    private void OnMouseDown()
    {
        Debug.Log("pushAttack.cs - OnMouseDown(): Enters");

        this.damage = Random.Range(1, 9);

        HealthManager health = HealthManager.getInstance();
        if (! health.isDead(objectID)) // if you arent dead
        {
            if (this.isFox) health.updateHealthKnight(this.damage, this.otherObjectAnimator);
            else health.updateHealthFox(this.damage, this.otherObjectAnimator);
            this.animator.Play(this.animationName);
        }
        Handheld.Vibrate();
    }


}
