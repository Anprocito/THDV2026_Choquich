using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyChaser : MonoBehaviour
{
    [Header("Objetivo")]
    [SerializeField] private Transform target;

    [Header("Balance")]
    [SerializeField] private float speed = 3f;
    [SerializeField] private float detectionRange = 10f;
    [SerializeField] private float stoppingDistance = 1.2f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Falta asignar el Target en " + name);
            return;
        }

        Vector3 toTarget = target.position - transform.position;
        toTarget.y = 0f;

        float distance = toTarget.magnitude;

        if (distance > detectionRange || distance <= stoppingDistance) return;

        Vector3 direction = toTarget.normalized;
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }

    // Dibuja el rango de detección en la Scene cuando el enemigo está seleccionado.
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}