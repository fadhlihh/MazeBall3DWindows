using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirin : MonoBehaviour
{
    // Membuat variable untuk direferensikan ke transform
    [SerializeField]
    Transform transformLabirin;
    [SerializeField]
    float kecepatanRotasi;

    // Variable untuk menentukan nilai rotasi labirin saat ini
    Vector3 rotasiSekarang = new Vector3(0, 0, 0);

    void Start()
    {
    }

    void Update()
    {
        // Mendeteksi input selama 2 ditekan
        if (Input.GetKey(KeyCode.W))
        {
            // Kode di dalam blok if ini akan dijalankan selama W ditekan
            // Mendapatkan nilai rotasi sekarang
            // rotasi sekarang dirotasi di sumbu W +1 (arah atas) dengan kecepetan rotasi yang telah ditentukan
            rotasiSekarang = rotasiSekarang + new Vector3(1, 0, 0) * kecepatanRotasi * Time.deltaTime;
        }

        // Mendeteksi input selama S ditekan
        if (Input.GetKey(KeyCode.S))
        {
            // Kode di dalam blok if ini akan dijalankan selama S ditekan
            // Mendapatkan nilai rotasi sekarang
            // rotasi sekarang dirotasi di sumbu x -1 (arah bawah) dengan kecepetan rotasi yang telah ditentukan
            rotasiSekarang = rotasiSekarang + new Vector3(-1, 0, 0) * kecepatanRotasi * Time.deltaTime;
        }

        // Mendeteksi input selama A ditekan
        if (Input.GetKey(KeyCode.A))
        {
            // Kode di dalam blok if ini akan dijalankan selama A ditekan
            // Mendapatkan nilai rotasi sekarang
            // rotasi sekarang dirotasi di sumbu z +1 (arah kiri) dengan kecepetan rotasi yang telah ditentukan
            rotasiSekarang = rotasiSekarang + new Vector3(0, 0, 1) * kecepatanRotasi * Time.deltaTime;
        }

        // Mendeteksi input selama D ditekan
        if (Input.GetKey(KeyCode.D))
        {
            // Kode di dalam blok if ini akan dijalankan selama D ditekan
            // Mendapatkan nilai rotasi sekarang
            // rotasi sekarang dirotasi di sumbu z -1 (arah kanan) dengan kecepetan rotasi yang telah ditentukan
            rotasiSekarang = rotasiSekarang + new Vector3(0, 0, -1) * kecepatanRotasi * Time.deltaTime;
        }

        // Membatasi rotasi di sumbu x, minimum -20, maksimum 20
        rotasiSekarang.x = Mathf.Clamp(rotasiSekarang.x, -20, 20);
        // Membatasi rotasi di sumbu z, minimum -20, maksimum 20
        rotasiSekarang.z = Mathf.Clamp(rotasiSekarang.z, -20, 20);

        // Mengubah rotasi dari component transform labirin dengan nilai variable rotasi sekarang
        // Nilai vector rotasi perlu dikorvensi ke sudut menggunakan Quaternion.Euler
        transformLabirin.rotation = Quaternion.Euler(rotasiSekarang);
    }
}
