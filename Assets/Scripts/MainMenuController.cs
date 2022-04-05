using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject AnaMenu;
    public GameObject AyarlarMenusu;
    public GameObject NasilOynanirMenusu;
    public GameObject HazirlayanlarMenusu;


    public void OyunuBaslat()
    {
        Debug.Log("1 indexli sahne yukleniyor...");
        SceneManager.LoadScene(1);
    }

    public void Ayarlar()
    {
        Debug.Log("Ayarlar Menusu");
        AnaMenu.SetActive(false);
        AyarlarMenusu.SetActive(true);
    }

    public void NasilOynanir()
    {
        Debug.Log("NasilOynanir Menusu");
        AnaMenu.SetActive(false);
        NasilOynanirMenusu.SetActive(true);
    }

    public void Hazirlayanlar()
    {
        Debug.Log("Hazirlayanlar Menusu");
        AnaMenu.SetActive(false);
        HazirlayanlarMenusu.SetActive(true);
    }

    public void AnaMenuDon()
    {
        Debug.Log("Ana Menu");
        AyarlarMenusu.SetActive(false);
        NasilOynanirMenusu.SetActive(false);
        HazirlayanlarMenusu.SetActive(false);
        AnaMenu.SetActive(true);
    }

    public void Cikis()
    {
        Debug.Log("Oyundan Cikildi");
        Application.Quit();
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
