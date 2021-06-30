using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn_action_rotar : MonoBehaviour
{
    public GameObject vbBtnObj;
    public Animator cubeAni;
    public float time_reboot = 3.0f;
    public float current_time = 0.0f;
    public bool pulsado = false;
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("Laciebtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("cube_animation");
        Debug.Log("Button pressed");
        //SLEEP Xs yield blablabla
        //yield return new WaitForSeconds(3);
        pulsado = true;
        if (current_time > time_reboot)
        {
            current_time = 0.0f;
            pulsado = false;
            SceneManager.LoadScene("SampleScene");
        }
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Button released");
    }
    // Update is called once per frame
    void Update()
    {
        if (pulsado)
        {
            current_time += Time.deltaTime;
        }
    }
}
