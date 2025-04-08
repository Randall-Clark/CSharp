# 🐾 Exercice C# – Héritage, Classes Abstraites et Polymorphisme

## 🧠 Concepts couverts

- 🧬 Héritage (`Inheritance`)
- 🧱 Classes Abstraites (`Abstract Classes`)
- 🔁 Redéfinition de méthodes (`Method Overriding`)
- 📦 Tableau d’objets (`Array of Objects`)
- 📨 Objet passé en paramètre (`Object as Parameter`)

---

## 📋 Énoncé

Dans cet exercice, tu dois implémenter un système de gestion d’un refuge pour animaux.

Chaque animal possède un nom et peut produire un son caractéristique. Le refuge doit pouvoir interagir avec plusieurs animaux via une interface commune.

### Objectifs :

- Créer une classe abstraite `Animal` contenant :
  - une propriété `Name`
  - une méthode abstraite `MakeSound()`
  - une méthode virtuelle `DisplayInfo()`
- Créer deux classes concrètes qui héritent de `Animal` :
  - `Dog`, qui affiche `"Woof!"` et redéfinit `DisplayInfo()`
  - `Cat`, qui affiche `"Meow!"` et utilise ou redéfinit `DisplayInfo()`
- Créer une classe `Shelter` avec une méthode `IntroduceAnimal(Animal animal)` qui appelle `MakeSound()` et `DisplayInfo()`.
- Dans la méthode `Main()` :
  - Créer un tableau `Animal[]` contenant plusieurs `Dog` et `Cat`.
  - Parcourir le tableau et appeler `IntroduceAnimal()` pour chaque animal.

---

# 🧪 Résultat de L'étudiant
Ce projet démontre une bonne compréhension des concepts suivants en C# :

- 🧬 Héritage (`Inheritance`)
- 🧱 Classes abstraites (`Abstract Classes`)
- 🔁 Redéfinition de méthodes (`Method Overriding`)
- 📦 Tableaux d'objets (`Array of Objects`)
- 📨 Objet en paramètre de méthode (`Object as Parameter`)

---

## ✅ Ce qui est bien maîtrisé

| Élément                         | Commentaire |
|--------------------------------|-------------|
| **Héritage**                   | `Cat` et `Dog` héritent proprement d'`Animal`. |
| **Classe abstraite**           | La classe `Animal` est abstraite avec une méthode abstraite `MakeSound()` et une méthode virtuelle `DisplayInfo()`. |
| **Override**                   | Les classes dérivées redéfinissent correctement les méthodes, notamment `MakeSound()` et `DisplayInfo()`. |
| **Objet passé en paramètre**   | `IntroduceAnimal(Animal animal)` montre la capacité à utiliser des objets en paramètres. |
| **Tableau d’objets**           | Création d’un tableau `Animal[]` avec plusieurs instances de différentes classes. |
| **Code fonctionnel et propre** | L'ensemble fonctionne sans erreurs et est bien structuré. |

---

## ⚠️ Points à améliorer

| Élément                        | Détail |
|-------------------------------|--------|
| 🔸 Nom du paramètre `animals` | Le paramètre dans `IntroduceAnimal(Animal animals)` représente un seul objet, il vaudrait mieux l’appeler `animal`. |
| 🔸 Texte de `Dog.DisplayInfo()` | Il manque un espace : `I am a Dog name{Name}` devrait être `I am a Dog named {Name}`. |
| 🔸 `using` superflus | Certaines directives `using` (`System.Linq`, `System.IO`, etc.) ne sont pas utilisées et peuvent être supprimées. |
| 🔸 Utilisation de `base.DisplayInfo()` | Dans `Dog.DisplayInfo()`, appeler `base.DisplayInfo()` avant d'ajouter un message aurait renforcé la démonstration de l’héritage. |

---

## 📊 Note finale

| Critère                          | Points |
|----------------------------------|--------|
| Structure & organisation         | 4 / 4  |
| Héritage, classe abstraite       | 5 / 5  |
| Override & encapsulation         | 3.5 / 4 |
| Utilisation concrète (`Main()`)  | 4 / 4  |
| Complet & fonctionnel            | 1.5 / 2 |

🎯 **Total : 18 / 20**

---

## ✨ Propositions d’amélioration

- Ajouter une nouvelle classe (ex. `Bird`) pour diversifier le polymorphisme
- Ajouter une méthode `IntroduceAllAnimals()` dans `Shelter` pour montrer l'utilisation de tableaux dans les méthodes
- Utiliser `base.DisplayInfo()` pour enrichir les `override`
- Ajouter des propriétés supplémentaires (`Age`, `Species`, etc.) pour une gestion plus riche

---

Bravo pour ce travail bien structuré et pédagogique 💪