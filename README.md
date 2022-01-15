# Sistem Penitipan Barang
> Sebuah project akhir mata kuliah pemrograman visual oleh kelompok dua

Merupakan sistem manajemen penitipan barang loker yang dilengkapi dengan perhitungan tagihan otomatis.

## Contributor
- Alifia Ayu Masita
- Daffa Raihansyah Kurnia
- Rizky Adi

## Requirements Project

### Class
1. Users
2. Locker
3. Jenis Locker
4. Sewa

### Form
1. Sign In
2. Sign Up
3. Form Sewa (menampilkan form dengan textbox rencana sewa (waktu) dan akan tampil biaya sewa total ”Hanya Input Sewa dan Waktu sewa (dalam jam)”)
4. Form Kembali  
5. Form Monitor Locker (Data Grid View Locker)
6. Tambah Locker
7. Edit Locker 
8. Ganti Status Locker (Isi, Kosong)
9. Hapus Locker
10. Form Data Sewa (Data Grid View Sewa)
11. Form Jenis Locker (Data Grid View Jenis Locker)
12. Tambah Jenis Locker
13. Update Jenis Locker
14. Hapus Jenis Locker

### Fitur
1. Dapat Sign In dan Sign Out
2. User Adalah Maintainer Locker
3. Form Monitor Locker berisi informasi status locker isi atau kosong dan info lain locker
4. Form Edit Locker memiliki fungsi mengganti informasi data locker
5. Form Ganti Status Locker mengganti Status locker isi atau kosong
6. Form Data Sewa berisi data sewa, dan saat data sewa di input status locker yang dipilih pada data locker akan diganti menjadi isi
7. Form Jenis Ukuran berisi data informasi jenis locker dan sub form tambah, ubah, dan hapus untuk memanipulasi data jenis ukuran
8. Penghitungan biaya sewa dihitung berdasarkan biaya di data jenis locker dikali lama penyewaan (jam).
9. Kelebihan Pinjam pada form penyewaan terjadi saat waktu pengembalian telah melewati waktu rencana pinjam

### Table
1. Users : (id, username, email, password)
2. Locker : (id, id_ukuran, lokasi, status)
3. Jenis_Ukuran : (id, ukuran, biaya)
4. Penyewaan : (id, id_locker, tanggal_sewa, tanggal_kembali, bayar_sebelum_pinjam, rencana_pinjam, kelebihan pinjam, total_bayar)




