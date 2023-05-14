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
        // El�z� �s jelenlegi panel poz�ci�ja
        Vector2 previousPosition = panelRectTransform.anchoredPosition;
        Vector2 currentPosition = Input.mousePosition;

        // Panel elmozdul�s�nak vektora
        Vector2 panelDelta = currentPosition - previousPosition;

        // Panel elh�z�s�nak ir�nya
        Vector2 swipeDirection = Vector2.zero;

        // X �s Y tengelyen m�rt elmozdul�s abszol�t �rt�ke
        float swipeThreshold = 50f;
        float xSwipe = Mathf.Abs(panelDelta.x);
        float ySwipe = Mathf.Abs(panelDelta.y);

        // Ir�ny kiv�laszt�sa az elmozdul�s alapj�n
        if (xSwipe > ySwipe && xSwipe > swipeThreshold)
        {
            swipeDirection = panelDelta.x > 0 ? Vector2.right : Vector2.left;
        }
        else if (ySwipe > xSwipe && ySwipe > swipeThreshold)
        {
            swipeDirection = panelDelta.y > 0 ? Vector2.up : Vector2.down;
        }

        // Ha az elh�z�s ir�nya jobbra vagy balra
        if (swipeDirection == Vector2.right || swipeDirection == Vector2.left)
        {
            isPanelVisible = true; // Panel elh�zva
            ShowGamePanel();
        }
        else
        {
            isPanelVisible = false; // Panel nincs elh�zva
        }
    }

    private void ShowGamePanel()
    {
        // Rungame Canvas panel megjelen�t�se
        RunGame.SetActive(true);
    }
}
