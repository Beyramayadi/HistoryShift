using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject pausemenu;
   public void cartage()
    {
        SceneManager.LoadScene("cartage");
    }
    public void rome()
    {
        SceneManager.LoadScene("rome");
    }
    public void islam()
    {
        SceneManager.LoadScene("islam");
    }
    public void france()
    {
        SceneManager.LoadScene("france");
    }
    public void republic()
    {
        SceneManager.LoadScene("republic");
    }
    public void replay()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Pausemenu()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void startmenuislam()
    {
        SceneManager.LoadScene("islam");
    }
    public void startmenucartage()
    {
        SceneManager.LoadScene("cartage");
    }
    public void startmenurome()
    {
        SceneManager.LoadScene("rome");
    }
    public void startmenufrance()
    {
        SceneManager.LoadScene("france");
    }
    public void startmenurepublic()
    {
        SceneManager.LoadScene("republic");
    }
}
