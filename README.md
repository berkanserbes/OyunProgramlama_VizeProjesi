# 3D 2 Kişilik Parkur Tamamlama Oyunu

## Oyunun Adı: Parkour Race 

## Oyunun Amacı
Parkurda bulunan iki oyuncu kendi parkurunun bitiş noktasına rakibinden önce ulaşarak galip gelmek.

## Oyun Tuşları

| **Oyuncu 1** | **Oyuncu 2** |      |
|-------------:|-------------|-------|
| **Tuş**      | **Tuş**     | **Görev** |
| W            |    ↑        | İleri hareket etme         |
| A            |    ←        | Sola hareket etme          |
| S            |    ↓        | Aşağı hareket etme         |
| D            |    →        | Sağa hareket etme          |
| Space        |    0        | Zıplama                    |
| CTRL         |    +        | Ateş etme                  |

## Oyun İçi Mekanikler

Oyun ekranı, sol tarafta Player1'in kamerası ve sağ tarafta Player2'nin kamerası olmak üzere ikiye bölünmüştür.

![Dual Camera](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/DualCamera.png?raw=true)

### Atış bölümü

Bu kısımda oyuncular duvardaki hedefleri yok ederek oyuna devam ederler. Hedefler yeşil ve kırmızı olmak üzere iki renkten oluşur ve belirli aralıklarla renkleri değişir. Eğer hedefin rengi kırmızıysa Oyuncu1 Space tuşuyla, Oyuncu2 + tuşuyla hedefleri yok edebilir.

![Target Area](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/ShootTarget.png?raw=true)

### Kutu bölümü

Bu kısımda oyuncular karşıdan gelen kutulardan kaçıp güvenli bölgelere ilerleyerek bu kısmı aşmak zorundadır. Eğer oyuncular kutu nesnesiyle çarpışırlarsa kutu tarafından platformun dışına sürüklenir.

![Box Collision](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/BoxCollision.png?raw=true)


Herhangi bir oyuncu ESC tuşuna bastığında oyun duraklatılır ve durdurma menüsü açılır. Bu durdurma menüsünde 'Devam Et' ve 'Yeniden Başlat' adlı iki adet buton bulunmaktadır. Oyuncu 'Devam Et' butonuna basarak oyuna kaldığı yerden devam edebilir veya 'Yeniden Başlat' butonuna basarak oyuna yeniden başlayabilir ya da yeniden ESC tuşuna basarak bu durdurma menüsünü kapatabilir.

![Pause Menu](https://github.com/berkanserbes/OyunProgramlama_VizeProjesi/blob/main/ScreenShot/PauseMenu.png?raw=true)
