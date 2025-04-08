# 💾 Exercice C# – Download Manager (Enum, Generics, Multithreading)

Cet exercice avait pour but de pratiquer des notions avancées en C# :

- ✅ Enum
- ✅ Propriétés auto-implémentées (getters / setters)
- ✅ Génériques (`DownloadManager<T>`)
- ✅ Multithreading avec `Thread`
- ✅ Encapsulation et séparation des responsabilités

---

## ✅ Ce qui a été bien réalisé

| Élément | Évaluation |
|--------|------------|
| **Enum `DownloadStatus`** | Bien défini et utilisé dans `DownloadTask` |
| **Structure de `DownloadTask`** | Le changement de statut, le `Thread.Sleep` et la logique métier sont clairs |
| **Logique de test dans `Main()`** | Bonne organisation, instanciation et utilisation prévue du gestionnaire |
| **Intention de design générique** | Tentative intéressante de créer une classe réutilisable via `DownloadManager<T>` |
| **Multithreading compris dans l'esprit** | Utilisation de `Thread` bien intégrée dans le concept général |

---

## ⚠️ Limites et erreurs bloquantes

| Point | Détail |
|------|--------|
| ❌ **Propriétés privées** | `FileName`, `Status`, etc. sont inaccessibles en dehors de `DownloadTask` — rend les tests impossibles |
| ❌ **Mauvaise utilisation des génériques** | Tu utilises `T` sans le contraindre à une base (`where T : DownloadTask`), donc le compilateur refuse l’appel à `StartDownload()` |
| ❌ **Téléchargements non synchronisés** | Les threads sont lancés mais non suivis (`Thread.Join()` manquant), donc le résultat affiché peut être faux |
| ❌ **Héritage mal utilisé** (dans une version précédente) | `DownloadManager<T>` n’a rien à hériter de `DownloadTask` |
| ❌ **Code non compilable** | L’ensemble plante à la compilation à cause des erreurs ci-dessus (visibilité + generics + thread) |

---

## 📊 Note finale : **11.5 / 20**

| Critère                          | Points |
|----------------------------------|--------|
| Enum                             | 2 / 2  |
| Auto-properties                  | 1 / 2  |
| Classe `DownloadTask`            | 2.5 / 3 |
| Génériques (`DownloadManager<T>`) | 2 / 4 |
| Multithreading                   | 1.5 / 3 |
| Design orienté objet             | 1 / 2  |
| Test dans `Main()`               | 1.5 / 2 |
| Code exécutable                  | 0 / 2  |

---

## 🧠 Pistes de progression

- ✅ Mieux comprendre la visibilité (`public`, `private`) pour accéder aux données
- ✅ Apprendre à **contraindre un type générique** avec `where T : BaseClass`
- ✅ Revoir la logique d’un **design orienté objet cohérent** (ne pas hériter d’un type inutilement)
- ✅ Approfondir la gestion de **threads synchronisés** (`Thread.Join`, verrouillage, état partagé)

---