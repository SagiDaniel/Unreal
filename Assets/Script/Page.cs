using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    public GameObject RunGame;

    private RectTransform panelRectTransform;
    private Animator panelAnimator;

    private bool isPanelVisible = false;

    private void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
        panelAnimator = GetComponent<Animator>();
    }

    public void DragPanel()
    {
        // Elõzõ és jelenlegi panel pozíciója
        Vector2 previousPosition = panelRectTransform.anchoredPosition;
        Vector2 currentPosition = Input.mousePosition;

        // Panel elmozdulásának vektora
        Vector2 panelDelta = currentPosition - previousPosition;

        // Panel elhúzásának iránya
        Vector2 swipeDirection = Vector2.zero;

        // X és Y tengelyen mért elmozdulás abszolút értéke
        float swipeThreshold = 50f;
        float xSwipe = Mathf.Abs(panelDelta.x);
        float ySwipe = Mathf.Abs(panelDelta.y);

        // Irány kiválasztása az elmozdulás alapján
        if (xSwipe > ySwipe && xSwipe > swipeThreshold)
        {
            swipeDirection = panelDelta.x > 0 ? Vector2.right : Vector2.left;
        }
        else if (ySwipe > xSwipe && ySwipe > swipeThreshold)
        {
            swipeDirection = panelDelta.y > 0 ? Vector2.up : Vector2.down;
        }

        // Ha az elhúzás iránya jobbra vagy balra
        if (swipeDirection == Vector2.right || swipeDirection == Vector2.left)
        {
            isPanelVisible = true; // Panel elhúzva
            ShowGamePanel();
        }
        else
        {
            isPanelVisible = false; // Panel nincs elhúzva
        }
    }

    private void ShowGamePanel()
    {
        // Rungame Canvas panel megjelenítése
        RunGame.SetActive(true);
    }
}
