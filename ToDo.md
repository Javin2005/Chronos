
---

**Fas 1: Fundamentet (Nätverk)**
- [ ] **Gemensamt:** Definiera "The Handshake" (hur klienten ansluter till servern).
- [ ] **Backend:** Sätta upp en grundläggande UDP-lyssnare i C++ (använd `ASIO`).
- [ ] **Frontend:** Sätta upp ett Unity-projekt som kan skicka ett "Ping"-paket till servern i C#.
- [ ] **Gemensamt:** Implementera binär serialisering (skicka inte JSON, skicka bytes!).

**Fas 2: Rörelse & Prediction (Viktigast för lag)**
- [ ] **Backend:** Bygga en Game Loop (Tick rate på t.ex. 64Hz).
- [ ] **Frontend:** Implementera Client-Side Prediction (gubben rör sig direkt).
- [ ] **Backend:** Implementera Authoritative Movement (servern säger var du *får* stå).
- [ ] **Frontend:** Implementera Reconciliation (klienten rättar sig efter servern om det blev fel).

**Fas 3: Grafik & Innehåll**
- [ ] **Vän:** Skapa 2.5D miljö i Unity (3D-värld med 2D-sprites).
- [ ] **Du:** Implementera kollisioner (AABB eller cirkel-kollisioner) i C++.

---


