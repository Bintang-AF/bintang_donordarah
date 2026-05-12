

Project aplikasi desktop menggunakan C# WinForms dan SQL Server.

## Anggota Kelompok / Identitas
- **Nama:** [Bintang aulia farhantifka]
- **NIM:** [20240140051]

  
-------------------------------------
sql injection
-------------------------------------

Proyek ini menyertakan simulasi celah keamanan SQL Injection pada fitur Pencarian Pendonor sebagai bahan edukasi:

Vulnerability: Fitur pencarian menggunakan Dynamic SQL yang menggabungkan input user secara langsung ke dalam query database.

Attack Scenario: Penyerang dapat memasukkan payload ' OR '1'='1 pada kolom pencarian untuk memanipulasi logika sistem.

Impact: Seluruh data pendonor akan ditampilkan tanpa filter, mengakibatkan kebocoran data sensitif.

Defense: Fitur lain dalam aplikasi ini sudah menggunakan Parameterized Queries untuk menjamin keamanan data dari serangan serupa.
