using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private float offset;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * moveSpeed;
        meshRenderer.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
