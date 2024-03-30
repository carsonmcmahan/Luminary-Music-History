using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class OpenPanel : MonoBehaviour
{
    [Tooltip("Number Panel we want to activate.")]
    [SerializeField] private int panelNumber;

    Button button;

    Transform panels;
    List<Transform> panelsList;

    private void Awake()
    {
        button = GetComponent<Button>();
        panelsList = new List<Transform>();
    }

    private void Start()
    {
        panels = GameObject.Find("Panels").transform;

        foreach (Transform panelTransform in panels)
        {
            panelsList.Add(panelTransform);
            SetGameObjectsInactive();
        }
    }

    private void OnEnable()
    {
        button.onClick.AddListener(() => ButtonPressed());
    }

    private void OnDisable()
    {
        button.onClick.RemoveAllListeners();
    }

    private void ButtonPressed()
    {
        SetGameObjectsInactive();

        if (panelNumber >= 0 && panelNumber < panelsList.Count)
        {
            panelsList[panelNumber].gameObject.SetActive(true);
        }
    }

    private List<Transform> SetGameObjectsInactive()
    {
        for (int i = 0; i < panelsList.Count; i++)
        {
            panelsList[i].gameObject.SetActive(false);
        }

        return panelsList;
    }
}
