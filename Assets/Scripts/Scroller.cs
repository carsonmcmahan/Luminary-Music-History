using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Created by Carson McMahan || 0/11/2024
 * This script is being used to animate the background to make it looke like it is moving.
 * Takes a raw image and a x, y for the seed
 */

[RequireComponent(typeof(RawImage))]
public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage scrollingBackground;
    [SerializeField] private float x, y;

    // Update is called once per frame
    void Update()
    {
        scrollingBackground.uvRect = 
            new Rect(scrollingBackground.uvRect.position + new Vector2(x, y) * Time.deltaTime, scrollingBackground.uvRect.size);
    }
}
