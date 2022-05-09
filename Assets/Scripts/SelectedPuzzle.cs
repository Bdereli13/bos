using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectedPuzzle : MonoBehaviour
{
    [SerializeField] GameObject StartPanel;
    public void SetPuzzlePhoto(Image Photo)
    {

        for (int i = 0; i < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        StartPanel.SetActive(false);

    }
}
