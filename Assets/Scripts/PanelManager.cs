using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [Tooltip("Transform containing all of the panels a UI wants to use.")]
    [SerializeField] private Transform panels;
    List<Transform> panelsList;

    private void Awake()
    {
        panelsList = new List<Transform>();
    }

    private void Start()
    {
        foreach (Transform panelTransform in panels)
        {
            panelsList.Add(panelTransform);
            SetGameObjectsInactive();
        }
    }

    /// <summary>
    /// Takes a panel number and sets the panel to true if it is within the count.
    /// </summary>
    /// <param name="panelNumber">Index for the panel list.</param>
    public void ButtonPressed(int panelNumber)
    {
        SetGameObjectsInactive();

        if (panelNumber >= 0 && panelNumber < panelsList.Count)
        {
            panelsList[panelNumber].gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// Takes all of the items in the panel list and sets them to false.
    /// </summary>
    /// <returns>Returns the panel list.</returns>
    private List<Transform> SetGameObjectsInactive()
    {
        for (int i = 0; i < panelsList.Count; i++)
        {
            panelsList[i].gameObject.SetActive(false);
        }

        return panelsList;
    }
}
