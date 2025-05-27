// FogScroller.cs
using UnityEngine;

public class FogScroller : MonoBehaviour
{
    public float scrollSpeedX = 0.01f;
    public float scrollSpeedY = 0.01f;
    private Renderer rend;
    private Vector2 offset;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        offset += new Vector2(scrollSpeedX, scrollSpeedY) * Time.deltaTime;
        rend.material.mainTextureOffset = offset;
    }
}
