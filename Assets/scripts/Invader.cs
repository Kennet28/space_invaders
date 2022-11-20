using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
   public Sprite[] animationSprites;
   public float animationTime = 1.0f;

   private SpriteRenderer spriteRenderer;
   private int _animationFrame;

   private void Awake()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();

   }

   private void Start()
   {
      InvokeRepeating(nameof(AnimateSprite),this.animationTime,this.animationTime);
   }

   private void AnimateSprite()
   {
      _animationFrame++;
      if (_animationFrame >= animationSprites.Length)
      {
         _animationFrame = 0;
      }

      spriteRenderer.sprite = this.animationSprites[_animationFrame];
   }
}
