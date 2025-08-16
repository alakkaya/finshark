# 🦈 FinShark - Financial Analysis Platform

![FinShark Logo](homepage.png)

FinShark, yatırımcıların kısa vadeli veri gürültüsü olmadan ilgili finansal belgeleri ve şirket bilgilerini bulmalarına yardımcı olan modern bir finansal analiz platformudur.

## 🌟 Özellikler

### 💼 Finansal Analiz

- **Şirket Profili**: Detaylı şirket bilgileri ve finansal metrikleri
- **Bilanço Analizi**: Şirketlerin finansal durumunu analiz etme
- **Nakit Akış Tabloları**: Nakit akışlarını takip ve analiz etme
- **Gelir Tabloları**: Şirket gelirlerini detaylı inceleme
- **Oran Analizi**: Finansal oranlar ve karşılaştırmalar
- **Temettü Geçmişi**: Geçmiş temettü ödemelerini takip

### 👤 Kullanıcı Yönetimi

- **Güvenli Kimlik Doğrulama**: JWT tabanlı güvenli giriş sistemi
- **Kullanıcı Kayıtı**: Güçlü şifre politikası ile güvenli kayıt
- **Kişiselleştirilmiş Deneyim**: Kullanıcı özel portfolyo yönetimi

### 📊 Portfolyo Yönetimi

- **Kişisel Portfolyo**: Hisse senetlerini takip ve yönetme
- **Yorum Sistemi**: Hisse senetleri hakkında not alma ve yorum yapma
- **Arama ve Filtreleme**: Gelişmiş arama ve filtreleme özellikleri

## 🛠️ Teknoloji Stack'i

### Backend (.NET 8 Web API)

- **Framework**: ASP.NET Core 8.0
- **Database**: MySQL (Entity Framework Core ile)
- **Authentication**: JWT Bearer Token
- **ORM**: Entity Framework Core
- **API Documentation**: Swagger/OpenAPI
- **Architecture**: Repository Pattern, Dependency Injection

### Frontend (React TypeScript)

- **Framework**: React 18 with TypeScript
- **Routing**: React Router DOM
- **Styling**: Tailwind CSS
- **Forms**: React Hook Form with Yup validation
- **HTTP Client**: Axios
- **Charts**: Recharts
- **Icons**: React Icons
- **Notifications**: React Toastify
- **State Management**: Context API

## 📁 Proje Yapısı

```
finshark/
├── 📁 api/                          # Backend .NET API
│   ├── 📁 Controllers/              # API Controllers
│   ├── 📁 Data/                     # Database Context
│   ├── 📁 Models/                   # Entity Models
│   ├── 📁 Dtos/                     # Data Transfer Objects
│   ├── 📁 Repository/               # Repository Pattern Implementation
│   ├── 📁 Services/                 # Business Logic Services
│   ├── 📁 Interfaces/               # Contracts and Interfaces
│   ├── 📁 Migrations/               # Database Migrations
│   └── 📁 Mappers/                  # Object Mapping
├── 📁 frontend/                     # Frontend React App
│   ├── 📁 src/
│   │   ├── 📁 Components/           # Reusable React Components
│   │   ├── 📁 Pages/                # Page Components
│   │   ├── 📁 Context/              # React Context (State Management)
│   │   ├── 📁 Services/             # API Services
│   │   ├── 📁 Models/               # TypeScript Types
│   │   └── 📁 Helpers/              # Utility Functions
│   └── 📁 public/                   # Static Assets
└── 📄 README.md                     # Proje Dokümantasyonu
```

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler

- .NET 8 SDK
- Node.js (v16 veya üzeri)
- MySQL Server
- Visual Studio Code (önerilen)

### Backend Kurulumu

1. **Proje klasörüne gidin**

   ```bash
   cd api
   ```

2. **NuGet paketlerini yükleyin**

   ```bash
   dotnet restore
   ```

3. **Veritabanı bağlantı dizesini yapılandırın**

   - `appsettings.json` dosyasında MySQL bağlantı dizesini güncelleyin

4. **Veritabanı migrasyonlarını çalıştırın**

   ```bash
   dotnet ef database update
   ```

5. **API'yi çalıştırın**
   ```bash
   dotnet run
   ```

API `https://localhost:5001` adresinde çalışacaktır.

### Frontend Kurulumu

1. **Frontend klasörüne gidin**

   ```bash
   cd frontend
   ```

2. **NPM paketlerini yükleyin**

   ```bash
   npm install
   ```

3. **Geliştirme sunucusunu başlatın**
   ```bash
   npm start
   ```

Frontend `http://localhost:3000` adresinde çalışacaktır.

## 📊 API Endpoints

### 🔐 Authentication

- `POST /api/account/register` - Kullanıcı kaydı
- `POST /api/account/login` - Kullanıcı girişi

### 📈 Stocks

- `GET /api/stock` - Tüm hisse senetlerini listele
- `GET /api/stock/{id}` - Belirli bir hisse senedini getir
- `POST /api/stock` - Yeni hisse senedi ekle
- `PUT /api/stock/{id}` - Hisse senedi güncelle
- `DELETE /api/stock/{id}` - Hisse senedi sil

### 💼 Portfolio

- `GET /api/portfolio` - Kullanıcı portfolyosunu getir
- `POST /api/portfolio` - Portfolyoya hisse ekle
- `DELETE /api/portfolio/{symbol}` - Portfolyodan hisse çıkar

### 💬 Comments

- `GET /api/comment/{stockId}` - Hisse yorumlarını getir
- `POST /api/comment/{stockId}` - Yeni yorum ekle
- `PUT /api/comment/{id}` - Yorum güncelle
- `DELETE /api/comment/{id}` - Yorum sil

## 🔧 Geliştirme

### Kod Standardları

- **C#**: Microsoft C# Coding Conventions
- **TypeScript/React**: ESLint ve Prettier konfigürasyonu
- **Database**: Code First approach with Entity Framework

### Güvenlik

- JWT token tabanlı kimlik doğrulama
- Güçlü şifre politikası (12+ karakter, büyük/küçük harf, rakam, özel karakter)
- CORS politikaları
- SQL Injection koruması (Entity Framework)

## 🧪 Testing

### Backend Testing

```bash
cd api
dotnet test
```

### Frontend Testing

```bash
cd frontend
npm test
```

## 📦 Deployment

### Backend Deployment

```bash
cd api
dotnet publish -c Release -o ./publish
```

### Frontend Deployment

```bash
cd frontend
npm run build
```

## 🤝 Katkıda Bulunma

1. Projeyi fork edin
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için `LICENSE` dosyasına bakın.

## 📞 İletişim

Proje Sahibi - [GitHub Profili](https://github.com/alakkaya)

Proje Linki: [https://github.com/alakkaya/finshark](https://github.com/alakkaya/finshark)

---

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!
