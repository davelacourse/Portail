using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIStart : MonoBehaviour
{
    [SerializeField] private Button _boutonSelectedDepart2024 = default(Button);
    [SerializeField] private Button _boutonSelectedDepart2025 = default(Button);
    [SerializeField] private TMP_Text _txtSpaceShooter = default(TMP_Text);
    [SerializeField] private TMP_Text _txtPolygo = default(TMP_Text);
    [SerializeField] private TMP_Text _txtMysticArena = default(TMP_Text);
    [SerializeField] private TMP_Text _txtNovaZero = default(TMP_Text);
    [SerializeField] private TMP_Text _txtLaChasseAuxMots = default(TMP_Text);
    [SerializeField] private TMP_Text _txtZombieInvasion = default(TMP_Text);
    [SerializeField] private TMP_Text _txtEleivatup = default(TMP_Text);
    [SerializeField] private TMP_Text _txtSlime = default(TMP_Text);
    [SerializeField] private TMP_Text _txtHatsune = default(TMP_Text);
    [SerializeField] private TMP_Text _txtFarmageddon = default(TMP_Text);
    [SerializeField] private TMP_Text _txtSpaceShooter2 = default(TMP_Text);
    [SerializeField] private GameObject _panneau2024 = default(GameObject);
    [SerializeField] private GameObject _panneau2025 = default(GameObject);
    [SerializeField] private Button _bouton2025 = default(Button);
    [SerializeField] private Button _bouton2024 = default(Button);


    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        if (_panneau2024.activeSelf)
        {
            EventSystem.current.SetSelectedGameObject(_boutonSelectedDepart2024.gameObject);
        }
        else
        {
            EventSystem.current.SetSelectedGameObject(_boutonSelectedDepart2025.gameObject);
        }
            

        if (PlayerPrefs.HasKey("SpaceShooter"))
        {
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("SpaceShooter").ToString() + ")";
            _txtSpaceShooter2.text = "(" + PlayerPrefs.GetInt("SpaceShooter").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("SpaceShooter", 0);
            _txtSpaceShooter.text = "(" + PlayerPrefs.GetInt("SpaceShooter").ToString() + ")";
            _txtSpaceShooter2.text = "(" + PlayerPrefs.GetInt("SpaceShooter").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("Polygo"))
        {
            _txtPolygo.text = "(" + PlayerPrefs.GetInt("Polygo").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("Polygo", 0);
            _txtPolygo.text = "(" + PlayerPrefs.GetInt("Polygo").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("MysticArena"))
        {
            _txtMysticArena.text = "(" + PlayerPrefs.GetInt("MysticArena").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("MysticArena", 0);
            _txtMysticArena.text = "(" + PlayerPrefs.GetInt("MysticArena").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("NovaZero"))
        {
            _txtNovaZero.text = "(" + PlayerPrefs.GetInt("NovaZero").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("NovaZero", 0);
            _txtNovaZero.text = "(" + PlayerPrefs.GetInt("NovaZero").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("LaChasseAuxMots"))
        {
            _txtLaChasseAuxMots.text = "(" + PlayerPrefs.GetInt("LaChasseAuxMots").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("LaChasseAuxMots", 0);
            _txtLaChasseAuxMots.text = "(" + PlayerPrefs.GetInt("LaChasseAuxMots").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("ZombieInvasion"))
        {
            _txtZombieInvasion.text = "(" + PlayerPrefs.GetInt("ZombieInvasion").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("ZombieInvasion", 0);
            _txtZombieInvasion.text = "(" + PlayerPrefs.GetInt("ZombieInvasion").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("Eleivatup"))
        {
            _txtEleivatup.text = "(" + PlayerPrefs.GetInt("Eleivatup").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("Eleivatup", 0);
            _txtEleivatup.text = "(" + PlayerPrefs.GetInt("Eleivatup").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("Slime"))
        {
            _txtSlime.text = "(" + PlayerPrefs.GetInt("Slime").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("Slime", 0);
            _txtSlime.text = "(" + PlayerPrefs.GetInt("Slime").ToString() + ")";
        }

        // ========== 2025 =============

        if (PlayerPrefs.HasKey("Hatsune"))
        {
            _txtHatsune.text = "(" + PlayerPrefs.GetInt("Hatsune").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("Hatsune", 0);
            _txtHatsune.text = "(" + PlayerPrefs.GetInt("Hatsune").ToString() + ")";
        }

        if (PlayerPrefs.HasKey("Farmageddon"))
        {
            _txtFarmageddon.text = "(" + PlayerPrefs.GetInt("Farmageddon").ToString() + ")";
        }
        else
        {
            PlayerPrefs.SetInt("Farmageddon", 0);
            _txtFarmageddon.text = "(" + PlayerPrefs.GetInt("Farmageddon").ToString() + ")";
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

    public void StartSlime()
    {
        PlayerPrefs.SetInt("Slime", (PlayerPrefs.GetInt("Slime") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../SlimeContreTous/SlimeContreTous.exe");
        Application.Quit();
    }

    // ====== 20205 ==================
    
    public void StartHatsune()
    {
        PlayerPrefs.SetInt("Hatsune", (PlayerPrefs.GetInt("Hatsune") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../Hatsune/Hatsune.exe");
        Application.Quit();
    }

    public void StartFarmageddon()
    {
        PlayerPrefs.SetInt("Farmageddon", (PlayerPrefs.GetInt("Farmageddon") + 1));
        System.Diagnostics.Process.Start(Application.dataPath + "/../../Farmageddon/Farmageddon.exe");
        Application.Quit();
    }

    public void ChangerAnnee2024()
    {
        _panneau2024.SetActive(true);
        _panneau2025.SetActive(false); 
        //EventSystem.current.SetSelectedGameObject(null);
        //EventSystem.current.SetSelectedGameObject(_boutonSelectedDepart2024.gameObject);
        _bouton2024.image.color = new Color32(115, 115, 115, 255);
        _bouton2025.image.color = new Color32(255, 255, 255, 255);
    }

    public void ChangerAnnee2025()
    {
        _panneau2024.SetActive(false);
        _panneau2025.SetActive(true);
        //EventSystem.current.SetSelectedGameObject(null);
        //EventSystem.current.SetSelectedGameObject(_boutonSelectedDepart2025.gameObject);
        _bouton2025.image.color = new Color32(115, 115, 115, 255);
        _bouton2024.image.color = new Color32(255, 255, 255, 255);
    }
}
