using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    public GameObject iconPrefab;
    public GameObject Obj;
    public List<Collectibles> collectibles = new List<Collectibles>();
    public RawImage compassImage;
    public Transform player;

    public float maxDistance = 200f;

    float compassUnit;
    /*
    public Collectibles one;
    public Collectibles two;

    public Collectibles three;
    public Collectibles four;
    public Collectibles five;
    */




    private void Start()
    {
        compassUnit = compassImage.rectTransform.rect.width / 360f;
        foreach (Collectibles marker in collectibles)
        {
            AddQuestMArker(marker);
        }


    }

    private void Update()
    {
        compassImage.uvRect = new Rect(player.localEulerAngles.y / 360f, 0f, 1f, 1f);

        foreach (Collectibles marker in collectibles)
        {
            if (marker != null)
            {
                marker.image.rectTransform.anchoredPosition = GetPosOnCompass(marker);

                float dst = Vector2.Distance(new Vector2(player.transform.position.x, player.transform.position.z), marker.position);
                float scale = 0f;

                if (dst < maxDistance)
                    scale = 1f - (dst / maxDistance);

                marker.image.rectTransform.localScale = Vector3.one * scale;
            }

        }
    }

    public void AddQuestMArker(Collectibles marker)
    {
        GameObject newMarker = Instantiate(iconPrefab, compassImage.transform);
        marker.image = newMarker.GetComponent<Image>();
        marker.image.sprite = marker.icon;


    }

    public void removeMarker(Collectibles marker)
    {
        marker.image.gameObject.SetActive(false);
        collectibles.Remove(marker);
    }

    Vector2 GetPosOnCompass(Collectibles marker)
    {
        Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.z);
        Vector2 playerFwd = new Vector2(player.transform.forward.x, player.transform.forward.z);

        float angle = Vector2.SignedAngle(marker.position - playerPos, playerFwd);

        return new Vector2(compassUnit * angle, 0f);

    }
}