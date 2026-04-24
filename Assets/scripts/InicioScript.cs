using System;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{
    public GameObject panelInicio;
    public GameObject panelSettings;
    public GameObject AudioManagerObj;
    AudioSource AudioManagerSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void showSettings()
    {
        panelSettings.SetActive(true);

        panelSettings.SetActive(false);

        AudioManagerSource = AudioManagerObj.GetComponent<AudioSource>();
    }

    void SonarBoton()
    {
        GetComponent<AudioSource>().PlayOneShot(AudioManager.clipBotones);
    }

    public void exitSetting()
    {
        panelSettings.SetActive(true);

        panelInicio.SetActive(false);

        AudioManagerObj.GetComponent<AudioManager>().SonarBoton();
    }

    public void Inicio()
    {
        SceneManager.LoadScene("Juego");
    }
}
