using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private InputControls _inputControls;

    private void Awake()
    {
        _inputControls = new InputControls();
    }

    private void OnEnable()
    {
        _inputControls.Enable();
    }

    private void OnDisable()
    {
        _inputControls.Disable();
    }

    private void Start()
    {
        _inputControls.Player.PrimaryAttack.performed += context => OnPrimaryAttack();
        _inputControls.Player.SecondaryAttack.performed += context => OnSecondaryAttack();
        _inputControls.Player.Jump.performed += context => OnJump();
        _inputControls.Player.Dash.performed += context => OnDash();
        _inputControls.Player.Crouch.performed += context => OnCrouch();
        _inputControls.Player.Interact.performed += context => OnInteract();
        _inputControls.Player.OpenInventory.performed += context => OnOpenInventory();
        _inputControls.Player.UseSecondaryWeapon1.performed += context => OnUseSecondaryWeapon1();
        _inputControls.Player.UseSecondaryWeapon2.performed += context => OnUseSecondaryWeapon2();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 moveDirection = _inputControls.Player.AD.ReadValue<Vector2>();
        Vector3 direction = new Vector3(moveDirection.x, 0f, 0f);
        transform.position += direction * _moveSpeed * Time.deltaTime;   
    }

    public void OnPrimaryAttack()
    {
        Debug.Log("Primary Attack");
    }

    public void OnSecondaryAttack()
    {
        Debug.Log("Secondary Attack");
    }

    public void OnJump()
    {
        Debug.Log("Jump");
    }

    public void OnDash()
    {
        Debug.Log("Dash");
    }

    public void OnCrouch()
    {
        Debug.Log("Crouch");
    }

    public void OnInteract()
    {
        Debug.Log("Interact");
    }

    public void OnOpenInventory()
    {
        Debug.Log("Open Inventory");
    }

    public void OnUseSecondaryWeapon1()
    {
        Debug.Log("Use Secondary Weapon1");
    }

    public void OnUseSecondaryWeapon2()
    {
        Debug.Log("Use Secondary Weapon2");
    }
}