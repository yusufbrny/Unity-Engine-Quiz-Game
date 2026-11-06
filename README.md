# 🧠 Unity Engine Quiz Game — ScriptableObject Tabanlı Bilgi Yarışması

Etkinlik ve yarışmalar için **Unity 2022.3.9f1** ve **DOTween** kullanılarak geliştirilmiş; modüler `ScriptableObject` soru veritabanı, sesli/görsel cevap geri bildirimleri ve akıcı arayüz animasyonlarına sahip **2D Bilgi Yarışması (Quiz)** oyunudur.

---

## ✨ Temel Özellikler

- **ScriptableObject Soru Mimarisi (`Question.cs`)**:
  - Kod değişikliği gerektirmeden Unity Editor üzerinden sağ tıklayarak (`Create > Question`) yeni sorular, şıklar ve doğru cevap indeksleri oluşturabilme.
- **Oyun ve Skor Yönetimi (`QuizManager.cs`)**:
  - Soruların sırayla veya rastgele getirilmesi, doğru/yanlış cevap kontrolü, ses efektleri ve `Coroutine` destekli soru geçişleri.
- **DOTween Arayüz Animasyonları (`MainMenuUI.cs`, `PanelUI.cs`, `QuestionMenuUI.cs`)**:
  - Ana menü, soru kartları ve sonuç panellerinin **DOTween** ile yumuşak ölçeklendirme ve kayma animasyonlarıyla ekrana gelmesi.

---

## 📂 Proje Klasör Yapısı

```text
Unity-Engine-Quiz-Game/
└── Quiz Event/
    ├── Assets/
    │   ├── Plugins/Demigiant/  # DOTween animasyon kütüphanesi
    │   ├── Questions/          # ScriptableObject soru varlıkları (.asset)
    │   ├── Scenes/             # SampleScene.unity
    │   ├── Scripts/
    │   │   ├── MainMenuUI.cs
    │   │   ├── PanelUI.cs
    │   │   ├── Question.cs
    │   │   ├── QuestionMenuUI.cs
    │   │   └── QuizManager.cs
    │   └── Sprites/            # Arayüz ve buton görselleri
    ├── Packages/
    └── ProjectSettings/        # Unity 2022.3.9f1 proje ayarları
```

---

## 🚀 Kurulum ve Çalıştırma

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/yusufbrny/Unity-Engine-Quiz-Game.git
   ```
2. **Unity Hub** üzerinden **Unity 2022.3.9f1** ile `Quiz Event` klasörünü açın.
3. `Assets/Scenes/SampleScene.unity` sahnesini açarak yarışmayı başlatın.
