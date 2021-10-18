using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed=0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;
    private int totalCubes;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI cubesLeft;
    public ParticleSystem smoke;
    public ParticleSystem smoke1;
    public ParticleSystem smoke2;
    public ParticleSystem smoke3;
    public ParticleSystem smoke4;
    public ParticleSystem smoke5;
    public ParticleSystem smoke6;
    public AudioSource effect;




    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        smoke.Pause();
        smoke1.Pause();
        smoke2.Pause();
        smoke3.Pause();
        smoke4.Pause();
        smoke5.Pause();
        smoke6.Pause();
        count = 0;
        totalCubes = 7;
        SetCountText();
        
        


    }
    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        cubesLeft.text = "Cubes Left: " + (totalCubes - count).ToString();
        if (count >= totalCubes)
        {
            //Go to next scene
            SceneManager.LoadScene("ExitMenu");
        }
    }

   void OnMove(InputValue movementValue)
   {
       Vector2 movementVector = movementValue.Get<Vector2>();
       movementX= movementVector.x;
       movementY=movementVector.y;

   }

   void FixedUpdate()
   {
       Vector3 movement= new Vector3(movementX,0.0f,movementY);
       rb.AddForce(movement * speed);
   }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            //GameObject.FindWithTag("Smoke").GetComponent<ParticleSystem>().enableEmission = true;
            makeChanges(other);
            effect.Play();
            smoke.Play();

            //other.gameObject.SetActive(false);
            //count++;
           // SetCountText();
        }
        else if (other.gameObject.CompareTag("Pickup1"))
        {
            effect.Play();
            makeChanges(other);
            smoke1.Play();
                    
        }
        else if (other.gameObject.CompareTag("Pickup2"))
        {
            effect.Play();
            makeChanges(other);
            smoke2.Play();

        }
        else if (other.gameObject.CompareTag("Pickup3"))
        {
            effect.Play();
            makeChanges(other);
            smoke3.Play();

        }
        else if (other.gameObject.CompareTag("Pickup4"))
        {
            effect.Play();
            makeChanges(other);
            smoke4.Play();

        }
        else if (other.gameObject.CompareTag("Pickup5"))
        {
            effect.Play();
            makeChanges(other);
            smoke5.Play();

        }
        else if (other.gameObject.CompareTag("Pickup6"))
        {
            effect.Play();
            makeChanges(other);
            smoke6.Play();

        }


    }

    void makeChanges(Collider pickup)
    {
        pickup.gameObject.SetActive(false);
        count++;
        SetCountText();

    }
}
