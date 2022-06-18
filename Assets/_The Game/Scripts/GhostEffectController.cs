using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEffectController : MonoBehaviour
{
    [Header("Ghost Config")]
    [SerializeField] private GameObject ghostPrefab;
    [SerializeField] private float delayBetweenSpawns = 0.01f;
    [SerializeField] private float destroyTime = 0.3f;
    [SerializeField] private Color color;
    [SerializeField] private Material material = null;
    private float deltaTimer;
    
    //Cache Ref:
    private PlayerController _player;
    private SpriteRenderer _spriteRenderer;
    private SpriteRenderer _spriteRendererGhost;

    private void Awake()
    {
        _player = GetComponentInParent<PlayerController>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (deltaTimer > 0)
        {
            deltaTimer -= Time.deltaTime;
        }
        else
        {
            deltaTimer = delayBetweenSpawns;
            CreateGhost();
        }
    }

    public void CreateGhost()
    {
        GameObject gameObj = Instantiate(ghostPrefab, transform.position, transform.rotation);
        gameObj.transform.localScale = _player.transform.localScale;
        Destroy(gameObj, destroyTime);

        _spriteRendererGhost = gameObj.GetComponent<SpriteRenderer>();
        _spriteRendererGhost.sprite = _spriteRenderer.sprite;
        _spriteRendererGhost.color = color;
        if (material != null)
        {
            _spriteRendererGhost.material = material;
        }
    }
}
