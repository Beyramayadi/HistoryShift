using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeplacementObjet3D : MonoBehaviour
{
    public GameObject[] big;
    public GameObject[] small;
    int cntrenemy;
    public SoundControl sound;
    public GameObject pausemenu;
    public GameObject endmenu;
    public GameObject animation1;
    public GameObject animation2;
    public GameObject animation3;
    public GameObject animation4;
    public GameObject animation5;
    public GameObject limit;
    int t = 500;
    Rigidbody rb;
    float dx;
    public float speed;
    public GameObject ObjectTodestroyA;
    public GameObject ObjectTodestroyb; 
    public GameObject enemy;
    public GameObject books;
    int s;
    float init;
    GameObject[] gameObjects;
    public Slider img;
    public Slider sldr;
    float timer;
    float timer1;
    float timer2;
    float timer3;
    float timer4;
    float time;
    int book;
    float position;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sldr.value = 1.0f;
        img.interactable = false;
        sldr.interactable = false;
        book = 0;
        position = 1.3f;
        timer3 = 10;
        timer4 = 0;
        endmenu.SetActive(false);
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer3 < 9 && timer3 > 2)
        {
            endmenu.SetActive(true);
        }
        cntrenemy++;
        timer += Time.deltaTime;
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;
        time += Time.deltaTime;
        
        if (sldr.value > 0 && img.value<1) {
            if (ObjectTodestroyA!= null && animation4.activeSelf)
            {
                animation1.SetActive(true);
                animation4.SetActive(false);
            }
            
        s+=2;
        dx = Input.acceleration.x * speed;

        // Limiter la position en x dans un certain intervalle
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.5f, 1.4f), transform.position.y, transform.position.z);

        Debug.Log(dx);
            if (timer > 3.0f)
            {
                objectToClonee(enemy);
                
                timer = 0.0f;
            }
            if (timer1 > 5.0f)
            {
                int s = cntrenemy % 2;
                objectToClonee(small[s]);

                timer1 = 0.0f;
            }
            if (timer2 > 7.0f)
            {
                int b = cntrenemy % 3;
                objectToClonee(big[b]);

                timer2 = 0.0f;
            }
            if (time > 13.0f)
            {

                objectToClone(books);
                
                time = 0.0f;
            }
        }
        else if (sldr.value == 0)
        {
            if (timer3 > 9) { 
            timer3 = 0.0f;
            }
            animation3.SetActive(true);
            animation1.SetActive(false);
            animation2.SetActive(false);
            animation4.SetActive(false);
            animation5.SetActive(false);
        }
        else if (img.value == 1)
        {

            animation3.SetActive(false);
            animation1.SetActive(false);
            animation2.SetActive(false);
            animation4.SetActive(false);
            animation5.SetActive(true);
            timer4 += Time.deltaTime;
            if(timer4 > 2.0f)
            {
                Scene currentScene = SceneManager.GetActiveScene();
                int sceneIndex = currentScene.buildIndex;
                Debug.Log(sceneIndex);
                
                
            }

        }
        if (transform.position.y - 1 > ObjectTodestroyA.transform.position.y)
        {
            Destroy(ObjectTodestroyA);
        }
        if (transform.position.y - 1 > ObjectTodestroyb.transform.position.y)
        {
            Destroy(ObjectTodestroyb);
        }

    }

    
    private void FixedUpdate()
    {
        // Appliquer la vélocité en 3D
        rb.velocity = new Vector3(dx, 0f, 0f);
            if (!animation3.activeSelf && !animation4.activeSelf)
        { 
            if (dx < 0)
            {
                animation1.SetActive(false);
                animation2.SetActive(true);
            }
            else 
            {
                animation1.SetActive(true);
                animation2.SetActive(false);
            }
        }
    }
    void objectToClonee(GameObject objectToclone)
    {
        GameObject clonedObject = Instantiate(objectToclone);
        clonedObject.transform.position = new Vector3(transform.position.x, transform.position.y+10 , transform.position.z);
        clonedObject.transform.rotation = objectToclone.transform.rotation;
        clonedObject.transform.localScale = objectToclone.transform.localScale;
        clonedObject.SetActive(true);
        ObjectTodestroyA = clonedObject;
    }
    void objectToClone(GameObject objectToclone)
    {
        
        GameObject clonedObject = Instantiate(objectToclone);
        clonedObject.transform.position = new Vector3(position, transform.position.y + 10, transform.position.z);
        clonedObject.transform.rotation = objectToclone.transform.rotation;
        clonedObject.transform.localScale = objectToclone.transform.localScale;
        clonedObject.SetActive(true);
        ObjectTodestroyb = clonedObject;
        position -=0.8f ;
        if (position < -1.5f)
        {
            position = 1.3f;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            sldr.value -= 0.1f;
            if (animation1.activeSelf)
            {
                animation4.SetActive(true);
                animation1.SetActive(false);
            }

            
        }
        if (collision.gameObject.CompareTag("enemy1"))
        {
            Destroy(collision.gameObject);
            sldr.value -= 0.2f;
            if (animation1.activeSelf)
            {
                animation4.SetActive(true);
                animation1.SetActive(false);
            }


        }
        if (collision.gameObject.CompareTag("enemy2"))
        {
            Destroy(collision.gameObject);
            sldr.value -= 0.3f;
            if (animation1.activeSelf)
            {
                animation4.SetActive(true);
                animation1.SetActive(false);
            }


        }
        if (collision.gameObject.CompareTag("book"))
        {
            

            img.value += 0.2f;
            Destroy(collision.gameObject);
            switch (book)
            {
                case 0: 
                    sound.play_music(0);
                    break;
                case 1: 
                    sound.play_music(1);
                    break;
                case 2: 
                    sound.play_music(2);
                    break;
                case 3: 
                    sound.play_music(3);
                    break;
                case 4: 
                    sound.play_music(4);
                    break;
            }
            book++;

        }
    }
}
