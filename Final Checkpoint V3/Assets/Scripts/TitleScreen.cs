using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour
{
    private Button button;
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private int carChoice;
    [SerializeField] private GameObject[] carPrefabs;
    [SerializeField] private Vector3 spawnPos = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChooseCar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChooseCar() // ABSTRACTION
    {
        Instantiate(carPrefabs[carChoice], spawnPos, carPrefabs[carChoice].transform.rotation);
        titleScreen.gameObject.SetActive(false);
    }
}
