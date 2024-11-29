using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIStart : MonoBehaviour
{
    [SerializeField] Button _boutonSelectedDepart = default(Button);
    [SerializeField] TMP_Text _txtSpaceShooter = default(TMP_Text);
    [SerializeField] TMP_Text _txtPolygo = default(TMP_Text);
    [SerializeField] TMP_Text _txtMysticArena = default(TMP_Text);
    [SerializeField] TMP_Text _txtNovaZero = default(TMP_Text);
    [SerializeField] TMP_Text _txtLaChasseAuxMots = default(TMP_Text);
    [SerializeField] TMP_Text _txtZombieInvasion = default(TMP_Text);
    [SerializeField] TMP_Text _txtEleivatup = default(TMP_Text);

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_boutonSelectedDepart.gameObject);

        if (PlayerPrefs.HasKey("SpaceShooter"))
        {
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("SpaceShooter").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("SpaceShooter", 0);
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("SpaceShooter").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("Polygo"))
        {
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("Polygo").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("Polygo", 0);
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("Polygo").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("MysticArena"))
        {
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("MysticArena").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("MysticArena", 0);
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("MysticArena").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("NovaZero"))
        {
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("NovaZero").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("NovaZero", 0);
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("NovaZero").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("LaChasseAuxMots"))
        {
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("LaChasseAuxMots").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("LaChasseAuxMots", 0);
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("LaChasseAuxMots").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("ZombieInvasion"))
        {
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("ZombieInvasion").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("ZombieInvasion", 0);
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("ZombieInvasion").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("Eleivatup"))
        {
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("Eleivatup").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("Eleivatup", 0);
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("Eleivatup").ToString() + ")";
        }


    }

    public void StartSpaceShooter()
    {
        PlayerPrefs.SetInt("SpaceShooter", (PlayerPrefs.GetInt("SpaceShooter") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../SpaceShooter/SpaceShooter.exe");
        Application.Quit();
    }

    public void StartPolygo()
    {
        PlayerPrefs.SetInt("Polygo", (PlayerPrefs.GetInt("Polygo") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../Polygo/Polygo.exe");
        Application.Quit();
    }

    public void StartMysticArena()
    {
        PlayerPrefs.SetInt("MysticArena", (PlayerPrefs.GetInt("MysticArena") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../MysticArena/MysticArena.exe");
        Application.Quit();
    }

    public void StartNovaZero()
    {
        PlayerPrefs.SetInt("NovaZero", (PlayerPrefs.GetInt("NovaZero") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../NovaZero/NovaZero.exe");
        Application.Quit();
    }

    public void StartLaChasseAuxMots()
    {
        PlayerPrefs.SetInt("LaChasseAuxMots", (PlayerPrefs.GetInt("LaChasseAuxMots") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../LaChasseAuxMots/LaChasseAuxMots.exe");
        Application.Quit();
    }

    public void StartZombieInvasion()
    {
        PlayerPrefs.SetInt("ZombieInvasion", (PlayerPrefs.GetInt("ZombieInvasion") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../ZombieInvasion/ZombieInvasion.exe");
        Application.Quit();
    }

    public void StartEleivatup()
    {
        PlayerPrefs.SetInt("Eleivatup", (PlayerPrefs.GetInt("Eleivatup") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../Eleivatup/Eleivatup.exe");
        Application.Quit();
    }
}
