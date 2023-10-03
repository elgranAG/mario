using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_di : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 playerVelocityInicial;
    public bool groundedPlayer;
    public float playerSpeed = 20.0f;
    public float horizontal = 1f;
    // Start is called before the first frame update
     private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void Update()
    {
        //if(GameManager.activado == false) return;

        Vector3 move = new Vector3(horizontal, 0,/*Input.GetAxis("Vertical")*/0);
        controller.Move(move * Time.deltaTime * playerSpeed);
    }
    public void OnControllerColliderHit(ControllerColliderHit hit){
        Debug.Log("Colosiono");
        horizontal = horizontal * -1;
    }
}
    