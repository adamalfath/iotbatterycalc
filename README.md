# IoT Battery Calculator
## Introduction 
<img src="https://github.com/adamalfath/iotbatterycalc/blob/master/media/iotbatterycalc-gui.png">  

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
Pertama hitung durasi perangkat aktif ![t_APH0](https://github.com/adamalfath/iotbatterycalc/blob/master/media/t_APH0.svg) dan sleep ![t_SPH0](https://github.com/adamalfath/iotbatterycalc/blob/master/media/t_SPH0.svg) dalam satu siklus per unit jam:  

![t_APH](https://github.com/adamalfath/iotbatterycalc/blob/master/media/t_APH.svg)  

![t_SPH](https://github.com/adamalfath/iotbatterycalc/blob/master/media/t_SPH.svg) 

Untuk menghitung konsumsi daya perangkat, jumlahkan konsumsi daya pada masing-masing mode (aktif dan sleep). Konsumsi daya ![Q_CPH0](https://github.com/adamalfath/iotbatterycalc/blob/master/media/Q_CPH0.svg) dihitung dengan mengkalikan arus dengan durasi per unit jam:  

![Q_CPH](https://github.com/adamalfath/iotbatterycalc/blob/master/media/Q_CPH.svg)  

atau per unit hari:  

![Q_CPD](https://github.com/adamalfath/iotbatterycalc/blob/master/media/Q_CPD.svg)

Kalkulasi lamanya waktu perangkat dapat berjalan ![t_run0](https://github.com/adamalfath/iotbatterycalc/blob/master/media/t_run0.svg) dengan kapasitas baterai yang tersedia ![Q_BAT0](https://github.com/adamalfath/iotbatterycalc/blob/master/media/Q_BAT0.svg) dapat dihitung menggunakan persamaan berikut:  

![Q_BAT](https://github.com/adamalfath/iotbatterycalc/blob/master/media/Q_BAT.svg)  

![t_run](https://github.com/adamalfath/iotbatterycalc/blob/master/media/t_run.svg)

Kalkulasi terkait recharging dan selisih daya per hari dapat dihitung menggunakan persamaan berikut:

![Q_PV](https://github.com/adamalfath/iotbatterycalc/blob/master/media/Q_PV.svg)  

![deltaQ](https://github.com/adamalfath/iotbatterycalc/blob/master/media/deltaQ.svg)  

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