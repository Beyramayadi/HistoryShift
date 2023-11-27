using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    
    public AudioClip music;
    public AudioClip walk;
    public AudioClip[] sfx;

    public GameObject menu;
    public AudioSource bg, sfx_src, walk_sfx;
    public bool s=true;
    // Start is called before the first frame update
    void Start()
    {
        bg.clip = music;
        bg.loop = true;
        bg.Play();
        bg.volume = 0.10f;

    }
    private void Update()
    {
        if (menu.activeSelf)
        {
            bg.volume = 0.0f;
        }
        if (!menu.activeSelf&& s)
        {
            bg.volume=0.10f;
            
        }
    }

    public void play_music(int index)
    {
        sfx_src.PlayOneShot(sfx[index], 3f);
    }
    

}