using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDPlayerController : MonoBehaviour
{
        [SerializeField]
        private float movementVelocity = 3f;

        private Controls controls;
        public Camera main;
        
    private void Awake() {
        controls = new Controls();
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }


    void Update()
    {
        Vector2 mouseScreenPosition = controls.Player.MousePosition.ReadValue<Vector2>();
        Vector3 mouseWorldPosition = main.ScreenToWorldPoint(mouseScreenPosition);
        Vector3 targetDirection = mouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

        Vector3 movement = controls.Player.Movement.ReadValue<Vector2>() * movementVelocity;
        transform.position += movement * Time.deltaTime;
    }
}
