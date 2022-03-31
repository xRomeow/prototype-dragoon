using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] protected Rigidbody2D rigidBody;
    //[SerializeField] protected AudioSource audioSource;

    private Controls controls;

    public Controls EntityControls
    {
        get { return this.controls; }
        set { this.controls = value; }
    }

    protected string sourceName = "";
    private float speed = 5f;

    protected float Speed
    {
        get { return this.speed; }
        set { this.speed = value; }
    }

    protected virtual void Initialize()
    {
        this.EntityControls = InputManager.Instance.GetControls();
    }

    protected void MovePosition(Vector2 move)
    {
        this.rigidBody.velocity = move;
    }


}
