using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIStart : MonoBehaviour
{
    [SerializeField] Button _boutonSelectedDepart = default(Button);

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(_boutonSelectedDepart.gameObject);
    }

    public void StartSpaceShooter()
    {
        System.Diagnostics.Process.Start(Application.dataPath + "/../../SpaceShooter/SpaceShooter.exe");
        Application.Quit();
    }

    public void StartPolygo()
    {
        System.Diagnostics.Process.Start(Application.dataPath + "/../../Polygo/Polygo.exe");
        Application.Quit();
    }

    public void StartMysticArena()
    {
        System.Diagnostics.Process.Start(Application.dataPath + "/../../MysticArena/MysticArena.exe");
        Application.Quit();
    }
}
