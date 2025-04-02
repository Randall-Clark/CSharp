# 🚗 Exercice C# – Gestion d’un Parc Automobile

Cet exercice permet de mettre en pratique les bases de la programmation orientée objet en **C#**, notamment :

- ✅ Classes & Objets
- ✅ Membres `static`
- ✅ Constructeurs
- ✅ Surcharge de constructeurs (`Overload Constructors`)

---

## 📚 Contexte

Le but est de créer un système simple de gestion de voitures dans un garage. Chaque voiture possède un modèle, une marque, une année de fabrication et un kilométrage.

---

## 💻 Objectifs

- Créer une classe `Car` avec les propriétés suivantes :
    - `string Model`
    - `string Brand`
    - `int ProductionYear`
    - `double Kilometers`

- Ajouter un champ **statique** `CarsCount` qui compte le nombre total de voitures créées.

- Implémenter :
    - Un **constructeur principal** prenant tous les paramètres.
    - Un **constructeur surchargé** prenant uniquement `Model` et `Brand`, avec des valeurs par défaut (`2020`, `0`) pour les autres.

- Incrémenter `CarsCount` à chaque création d’objet.

- Ajouter une méthode `DisplayInfo()` qui affiche les informations de la voiture dans la console.

---

# 🧪Resultat de l'exercice

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

🔧 Bravo pour ce projet bien structuré ! Tu démontres une bonne montée en compétence 👏
