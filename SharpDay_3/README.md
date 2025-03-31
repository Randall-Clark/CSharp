🚗 Exercice C# – Classes, Objets, Statique, Constructeurs et Surcharge
🎯 Objectif
Cet exercice a pour but de mettre en pratique les notions fondamentales de la programmation orientée objet en C#, notamment :

Les classes

Les objets

Les membres statiques

Les constructeurs

La surcharge de constructeurs

🧠 Contexte
Tu dois créer un système de gestion de voitures pour un garage. Chaque voiture aura un modèle, une marque, une année de fabrication et un nombre de kilomètres parcourus.

📋 Consignes
Créer une classe Car avec les propriétés suivantes :

string Model

string Brand

int ProductionYear

double Kilometers

Ajouter un champ statique CarsCount qui compte le nombre total de voitures créées.

Créer un constructeur principal avec tous les paramètres nécessaires (Model, Brand, ProductionYear, Kilometers).

Créer un constructeur surchargé qui ne prend que Model et Brand, et qui utilise des valeurs par défaut pour les autres (ProductionYear = 2020, Kilometers = 0). Ce constructeur doit utiliser this(...) pour appeler l'autre.

Incrémenter le compteur CarsCount à chaque création d’objet dans le constructeur principal.

Créer une méthode DisplayInfo() pour afficher les informations de chaque voiture dans la console.

Dans la méthode Main, créer plusieurs objets Car en utilisant les deux types de constructeurs. Afficher les informations de chaque voiture et le nombre total de voitures créées.

📌 Exemple d’utilisation dans Main
csharp
Copy
Edit
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
