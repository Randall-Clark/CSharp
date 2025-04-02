# 🚗 Exercice C# – Gestion d’un Parc Automobile

Cet exercice permet de mettre en pratique les bases de la programmation orientée objet en **C#**, notamment :

- ✅ Classes & Objets
- ✅ Membres `static`
- ✅ Constructeurs
- ✅ Surcharge de constructeurs (`Overload Constructors`)

---

## 📚 Contexte

Créer un système de facturation simplifié pour une boutique en ligne

---

## 💻 Objectifs : Créer un système de facturation simplifié pour une boutique en ligne

- Crée une interface IProduct avec :
  - Une propriété string Name
  - Une méthode double GetPrice()

- Crée une classe Book qui implémente IProduct :
  - Champs : Title, Author, Price
  - Implémente ToString() pour afficher : "Book: [Title] by [Author] - $[Price]"

- Crée une classe Electronic qui implémente IProduct :
  - Champs : Name, Brand, Price
  - Implémente ToString() pour afficher : "Electronic: [Name] - [Brand] - $[Price]"

- Crée une classe Order qui contient une List<IProduct> Products
  - Méthode AddProduct(IProduct product)
  - Méthode PrintInvoice() qui affiche tous les produits (grâce à ToString()) et le total

- Dans Main() :
  - Crée une commande
  - Ajoute des Book et des Electronic
  - Appelle PrintInvoice() pour voir les produits et le total
---

# 🧪Notation Final de l'exercice

# 🧾 Exercice C# – Interfaces, Polymorphisme, List et ToString

Ce projet met en pratique plusieurs notions clés de la programmation orientée objet en C# :

- ✅ Interface (`IProduct`)
- ✅ Polymorphisme avec `List<IProduct>`
- ✅ Redéfinition de `ToString()`
- ✅ Liste d'objets (`List<T>`)
- ✅ Manipulation d'objets dynamiquement (ajout, affichage, calcul)

---

## ✅ Ce qui est bien maîtrisé

| Élément                          | Évaluation |
|----------------------------------|------------|
| **Interface `IProduct`**         | Bien déclarée avec une propriété `Name` et une méthode `GetPrice()` |
| **Implémentation de l’interface**| `Book` et `Electronic` l’implémentent correctement |
| **Utilisation de `ToString()`**  | Chaque classe a une méthode propre et lisible |
| **Polymorphisme avec `List`**    | Bien utilisé dans la classe `Order` |
| **Encapsulation fonctionnelle**  | Ajout et affichage des produits bien faits |
| **Programme test complet**       | `Main()` instancie, ajoute, affiche et calcule comme demandé |

---

## ⚠️ Améliorations possibles

| Point à améliorer | Pourquoi c’est important |
|-------------------|--------------------------|
| 🔸 `PrintInvoice()` non utilisée | Soit la supprimer, soit l’utiliser pour afficher proprement |
| 🔸 Conventions C# | Une variable locale comme `TotalPrice` devrait s’écrire `totalPrice` |
| 🔸 Champs publics | `Author`, `Brand`, `Price` devraient être des propriétés pour respecter l'encapsulation |
| 🔸 Exploiter davantage l’interface | Tu pourrais afficher `Name` via l’interface pour plus de cohérence |

---

## 🧠 Note finale

| Critère                          | Points |
|----------------------------------|--------|
| Fonctionnalité / logique         | 5 / 5  |
| Interface & Polymorphisme        | 5 / 5  |
| `ToString()` & affichage         | 3 / 3  |
| Conventions, propreté            | 2 / 3  |
| Structure & encapsulation        | 2.5 / 4  |

🎯 **Total : 17.5 / 20**

---

## ✅ Idées pour aller plus loin

- Ajouter une interface `IDiscountable` avec une méthode `GetDiscountedPrice()`
- Trier les produits par prix
- Sauvegarder la facture dans un fichier texte
- Ajouter une catégorie de produit supplémentaire (ex: `Food`, `Subscription`, etc.)

---