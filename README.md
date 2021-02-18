# IoT Battery Calculator
## Introduction 
<img src="https://github.com/adamalfath/iotbatterycalc-gui/blob/master/media/iotbatterycalc-gui.png" width="600">  

Kalkulator sederhana untuk menghitung estimasi waktu aktif dari perangkat IoT (atau perangkat apapun secara general) yang dihidupkan menggunakan baterai. Disertai opsi untuk parameter recharging.

Aplikasi bisa didapatkan dengan mengunjungi halaman release atau pada link berikut:  
https://github.com/adamalfath/iotbatterycalc/releases/latest  

> **:information_source: Disclaimer**  
> Perhitungan dalam kalkulator ini disederhanakan untuk kebutuhan praktikal dan memungkinkan adanya perbedaan dengan kondisi asli. Silahkan lihat rumus yang digunakan pada bagian [teori](#Theory) untuk detail lebih lanjut.

## How to Use
### Input
- **Active Duration**: total waktu perangkat melakukan operasi normal (contoh: mengambil/mengirim data, menghubungkan ke jaringan internet, dll). Unit dalam satuan detik (s).
- **Active Current**: nilai arus yang dikonsumsi perangkat saat melakukan operasi normal. Perangkat mungkin memiliki konsumsi arus yang variatif saat berjalan, silahkan ambil nilai aproksimasi arus rataan. Unit dapat dipilih antara milliampere (mA) dan microampere (uA).
- **Sleep Duration**: total waktu perangkat berada dalam kondisi sleep/idle. Isi nilai 0 (nol) jika perangkat tidak pernah masuk dalam kondisi sleep/idle. Unit dalam satuan detik (s).
- **Sleep Current**: nilai arus yang dikonsumsi perangkat saat kondisi sleep/idle. Pada mode ini biasanya konsumsi arus bernilai konstan. Unit dapat dipilih antara milliampere (mA) dan microampere (uA).
- **Battery Capacity**: kapasitas baterai yang terpasang untuk menghidupkan perangkat. Unit dalam satuan milliampere-hour (mAh).
- **Discharge Limit**: batas persentase kapasitas baterai saat beroperasi (untuk pemakaian normal biasanya baterai tidak diperbolehkan untuk di discharge secara total). Isi nilai 0 (nol) untuk melakukan kalkulasi dengan 100% kapasitas baterai. Unit dalam persen (%).
- **PV Rated Current**: nilai rating arus dari solar cell (atau sumber eksternal lainnya) untuk me-recharge baterai. Isi nilai 0 (nol) jika parameter ini tidak digunakan. Unit dalam satuan milliampere (mA).
- **Peak Sun Hour**: total waktu sinar matahari (atau ketersediaan sumber eksternal lainnya) yang nilainya sebanding dengan waktu charging. Unit dalam satuan jam (h) per hari.

### Output
- **Usable Battery Capacity**: kapasitas baterai aktual yang dapat digunakan. Unit dalam satuan milliampere-hour (mAh).
- **PV Power Generated**: total energi yang dihasilkan oleh solar cell (atau sumber eksternal lainnya) dalam satu hari. Unit dalam satuan milliampere-hour (mAh).
- **Consumption per Hour**: rata-rata daya yang dikonsumsi perangkat per satuan jam. Unit dalam satuan milliampere-hour (mAh).
- **Consumption per Day**: rata-rata daya yang dikonsumsi perangkat per satuan hari. Unit dalam satuan milliampere-hour (mAh).
- **Estimated Run Time**: perkiraan waktu perangkat dapat aktif menggunakan baterai tanpa adanya proses recharging.
- **Energy Balance**: selisih antara daya yang dikonsumsi perangkat dengan daya yang dihasilkan solar cell (atau sumber eksternal lainnya) dalam satu hari. Nilai positif menandakan secara teori perangkat mencukupi untuk bisa terus berjalan selamanya tanpa kehabisan daya, nilai negatif menandakan perangkat akan mati saat daya baterai habis dalam waktu yang sudah dikalkulasikan. Unit dalam satuan milliampere-hour (mAh).

### Example
Dalam screenshot diatas diperlihatkan sebuah perangkat aktif per 30 menit sekali (1800s) dengan komposisi waktu aktif selama 10s @20mA dan sleep selama 1790s @20uA. Baterai yang digunakan berkapasitas 1000mAh tanpa rangkaian recharge dengan batas discharge 20%. Terhitung lama waktu perangkat dapat aktif yaitu ~254 hari 10 jam 52 menit 13 detik.

## Theory
Pertama hitung durasi perangkat aktif ![t_APH](https://latex.codecogs.com/svg.latex?%5Cinline%20t_%7BAPH%7D) dan sleep ![t_SPH](https://latex.codecogs.com/svg.latex?%5Cinline%20t_%7BSPH%7D) dalam satu siklus per unit jam:  

![t_APH](https://latex.codecogs.com/svg.latex?%5Cinline%20t_%7BAPH%7D%3D%5Cfrac%7Bt_%7Bactive%7D%7D%7Bt_%7Bactive%7D&plus;t_%7Bsleep%7D%7D*3600)  

![t_SPH](https://latex.codecogs.com/svg.latex?%5Cinline%20t_%7BSPH%7D%3D%5Cfrac%7Bt_%7Bsleep%7D%7D%7Bt_%7Bactive%7D&plus;t_%7Bsleep%7D%7D*3600) 

Untuk menghitung konsumsi daya perangkat, jumlahkan konsumsi daya pada masing-masing mode (aktif dan sleep). Konsumsi daya ![Q_CPH](https://latex.codecogs.com/svg.latex?%5Cinline%20Q_%7BCPH%7D) dihitung dengan mengkalikan arus dengan durasi per unit jam:  

![Q_CPH](https://latex.codecogs.com/svg.latex?%5Cinline%20Q_%7BCPH%7D%3D%28%5Cfrac%7Bt_%7BAPH%7D%7D%7B3600%7D*I_%7Bactive%7D%29&plus;%28%5Cfrac%7Bt_%7BSPH%7D%7D%7B3600%7D*I_%7Bsleep%7D%29)  

atau per unit hari:  

![Q_CPD](https://latex.codecogs.com/svg.latex?%5Cinline%20Q_%7BCPD%7D%3DQ_%7BCPH%7D*24)

Kalkulasi lamanya waktu perangkat dapat berjalan ![t_run](https://latex.codecogs.com/svg.latex?%5Cinline%20t_%7Brun%7D) dengan kapasitas baterai yang tersedia ![Q_BAT](https://latex.codecogs.com/svg.latex?%5Cinline%20Q_%7BBAT%7D) dapat dihitung menggunakan persamaan berikut:  

![Q_BAT](https://latex.codecogs.com/svg.latex?%5Cinline%20Q_%7BBAT%7D%3DQ_%7BBAT0%7D*%5Cfrac%7B100-%28Discharge%5C%3ALimit%29%7D%7B100%7D)  

![t_run](https://latex.codecogs.com/svg.latex?%5Cinline%20t_%7Brun%7D%3D%5Cfrac%7BQ_%7BBAT%7D%7D%7BQ_%7BCPH%7D%7D)

Kalkulasi terkait recharging dan selisih daya per hari dapat dihitung menggunakan persamaan berikut:

![Q_PV](https://latex.codecogs.com/svg.latex?%5Cinline%20Q_%7BPV%7D%3DI_%7BPV%7D*t_%7Bsun%7D)  

![deltaQ](https://latex.codecogs.com/svg.latex?%5Cinline%20%5CDelta%20Q%3DQ_%7BPV%7D-Q_%7BCPD%7D)  

## Support Open-Source Hardware & SENTSOR!
Bila kalian tertarik dengan produk-produk SENTSOR, kalian bisa cek marketplace ataupun memberikan donasi pada link berikut:  

[![Store](https://img.shields.io/badge/marketplace-Tokopedia-brightgreen.svg)](https://www.tokopedia.com/gerai-sagalarupa/etalase/sentsor-product)  [![Donate](https://img.shields.io/badge/donate-PayPal-blue.svg)](https://www.paypal.me/adamalfath)  

Support kalian akan sangat membantu untuk pengembangan open-source hardware dari SENTSOR selanjutnya.

## Information
SENTSOR  
Author: Adam Alfath  
Contact: adam.alfath23@gmail.com  
Web: [sentsor.net](http://www.sentsor.net)  
Repo: [SENTSOR Main Repo](http://github.com/adamalfath/sentsor)

<img src="https://www.gnu.org/graphics/gplv3-with-text-84x42.png" width="80"><br>
SENTSOR IoT Battery Calculator is licensed under <a rel="license" href="https://www.gnu.org/licenses/gpl-3.0.en.html">GNU General Public License v3.0</a>.