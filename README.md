<h3 align="center">22360859353 Berkan Serbes</h3>

<hr>
<p align="center">Oyunu tarayıcınızda oynamak için <a href="https://simmer.io/@berkanserbes/parkour-race" target="_blank"> tıklayın</a></p>
<hr>

# 3D 2 Kişilik Parkur Yarışı Oyunu 

## Oyunun Adı: Parkour Race 

## Oyunun Amacı
Parkurda bulunan iki oyuncunun kendi parkurunun bitiş noktasına rakibinden önce ulaşarak galip gelmek.

## Oyun Tuşları

| **Oyuncu 1** | **Oyuncu 2** |      |
|-------------:|-------------|-------|
| **Tuş**      | **Tuş**     | **Görev** |
| W            |    ↑        | İleri hareket etme         |
| A            |    ←        | Sola hareket etme          |
| S            |    ↓        | Geriye hareket etme        |
| D            |    →        | Sağa hareket etme          |
| Space        |    0        | Zıplama                    |
| CTRL         |    +        | Ateş etme                  |

## Oyun İçi Mekanikler

Oyun ekranı, sol tarafta Player1'in kamerası ve sağ tarafta Player2'nin kamerası olmak üzere ikiye bölünmüştür.

![Dual Camera](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/DualCamera.png?raw=true)

### Atış bölümü

Bu kısımda oyuncular duvardaki hedefleri yok ederek oyuna devam ederler. Hedefler yeşil ve kırmızı olmak üzere iki renkten oluşur ve belirli aralıklarla renkleri değişir. Eğer hedefin rengi kırmızıysa Oyuncu1 CTRL tuşuyla, Oyuncu2 + tuşuyla hedefleri yok edebilir.

![Target Area](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/ShootTarget.png?raw=true)

### Kutu bölümü

Bu kısımda oyuncular karşıdan gelen kutulardan kaçıp güvenli bölgelere ilerleyerek bu kısmı aşmak zorundadır. Eğer oyuncular kutu nesnesiyle çarpışırlarsa kutu tarafından platformun dışına sürüklenir.

![Box Collision](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/BoxCollision.png?raw=true)


Parkurun bitiş çizgisine ilk ulaşan oyuncu oyunu kazanır. Oyunun sonunda oyunu kazanan kişiyi gösteren ekran ortaya çıkar.

![Winner Screen](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/WinnerScreen.png?raw=true)


Herhangi bir oyuncu ESC tuşuna bastığında oyun duraklatılır ve durdurma menüsü açılır. Bu durdurma menüsünde 'Devam Et' ve 'Yeniden Başlat' adlı iki adet buton bulunmaktadır. Oyuncu 'Devam Et' butonuna basarak oyuna kaldığı yerden devam edebilir veya 'Yeniden Başlat' butonuna basarak oyuna yeniden başlayabilir ya da yeniden ESC tuşuna basarak bu durdurma menüsünü kapatabilir.

![Pause Menu](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/PauseMenu.png?raw=true)

<hr>

## Oyunu Geliştirenler ve Görevleri

Parkurun oluşturulmasını, oyuncuların mekaniğini (hareket, zıplama, ateş etme), parkurdaki cisimlerin mekaniklerini ve bunlarla ilgili scriptleri takım arkadaşım Samet Özkan geliştirdi.

Ben ise durdurma menüsününün gösterimi,kodlanması ve oyunu kimin kazandığını gösteren ekranı geliştirdim.
