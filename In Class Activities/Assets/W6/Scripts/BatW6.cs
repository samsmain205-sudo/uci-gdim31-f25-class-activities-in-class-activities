using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _batSpeed = 1.0f;
    [SerializeField]private Transform _playerTransform;

    public void startChase(){
        enabled = true;
    }
    public void stopChase(){
        enabled = false;
    }

    private void Update(){
        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _batSpeed * Time.deltaTime
        );
        
    }
    
}
