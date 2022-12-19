using UnityEngine;

namespace Assets.Scripts.GameLogic
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D m_Rigidbody;
        [SerializeField] private float _force;

        [SerializeField] private Animator animationController;
        private bool inAir;

        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {

#if UNITY_EDITOR
            if (Input.GetKeyDown(KeyCode.Space) && !inAir)
            {
                inAir = true;
                m_Rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
                animationController.SetBool("IsJumping", true);
            }
#endif

#if PLATFORM_ANDROID
            if (Input.touchCount > 0 && !inAir)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    inAir = true;
                    m_Rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
                    animationController.SetBool("IsJumping", true);
                }        
            }         
#endif
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                inAir = false;
                animationController.SetBool("IsJumping", false);
            }            
        }
    }
}
