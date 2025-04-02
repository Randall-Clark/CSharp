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

## 🧪 Exemple d’utilisation dans `Main`

```csharp
Car car1 = new Car("Continental GT", "Bentley", 2022, 100);
Car car2 = new Car("Escalade", "Cadillac", 2025, 10);
Car car3 = new Car("GLS Maybach", "Mercedes");
Car car4 = new Car("Van", "Toyota");
Car car5 = new Car("Fusion", "Ford");

car1.DisplayInfo();
car2.DisplayInfo();
car3.DisplayInfo();
car4.DisplayInfo();
car5.DisplayInfo();

Console.WriteLine($"Nombre total de voitures créées : {Car.CarsCount}");
