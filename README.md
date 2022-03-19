## Partie I: Librairie pour la manipulation des nombres complexes en C#

Ce Projet est un travail pratique pour le cours de Programmation en C# avec le framework cross plateform .NET Core

Ce projet  réalisé avec le framework .NET Core 6.0, cependant le code reste compatible avec .NET Core 5

### Travail demandé

Dans cet exercice, il est demandé de : 

1. Forker(to fork) le repository dans votre compte github
2. cloner le repository que vous venez de forker
3. Créer une branche portant votre nom complet en notation camel case (ex : ben_kanku_barthelemy)
4. Construire la solution (ensemble de projets) en tapant à la racine du projet la commande dotnet build
  ```bash
   dotnet build
   ```
   
4.1 Si la construction de la solution échoue probablement parce que l'on n'a pas encore installé toutes les extensions C# dans Visual Studio Code, il faut veuiller que l'installation soit complète.
4.2. La construction de la solution peut aussi échouer parce que l'on a installer une autre version de .NET Core par exemple la version .NET Core 5, dans ce cas il faut juste changer la version cible de .NET Core dans vos trois projets à savoir : 
        * NombreComplexe/NombreComplexe.csproj
        * NombreComplexeTest/NombreComplexeTest.csproj
        * Application/Application.csproj
Dans ces fichiers de projet, veuillez adapter la version de .NET Core cible pour correspondre à la version installée sur votre ordinateur.
Voici un exemple: Sur un ordinateur la version .NET Core 5 est installée 
Voici le contenu actuel du projet  **NombreComplexe/NombreComexe.csproj**
    
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\NombreComplexe\NombreComplexe.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    
    <TargetFramework>net6.0</TargetFramework>
    
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

Il faut remplacer la valeur de l'élément ```<TargetFramework>net6.0</TargetFramework>``` par ```<TargetFramework>net5.0</TargetFramework>```

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\NombreComplexe\NombreComplexe.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    
    <TargetFramework>net5.0</TargetFramework>
    
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

NB: Pour savoir quelle version de .NET Core est installée sur son environnement, voici la commande à tapez dans un terminal : 
```bash
dotnet --version
```

5. Tester les fonctionnalités en exécutant le projet Application/Application.csproj en tapant la commande suivante à la racine du repository :
  ```bash
  dotnet run --project Application/Application.csproj
  ```
6. Voir comment utiliser les différentes méthodes et opérateurs sur les nombres complexes dans la méthode Main du fichier Application/Program.cs
7. Écrire des tests unitaires dans le fichier NombreComplexeTest/NombreComplexeTest.cs, pour tester les méthodes et opérateurs de la classe NombreComplexe (fichier NombreComplexe/NombreComplexe.cs)
8. Tester toutes les méthodes et tous les opérateurs à l'aide des tests unitaires pour vérifier qu'ils sont bien implémentés. Il faut varier les tests dans des contextes variés de manière à les rendre exhaustifs. Plus il y a des tests, plus vous avez des points.
9. Lancer les tests unitaires automatiquement à l'aide de la commande suivante :
  ```bash
  dotnet test
  ```
10. Faire un commit de ses modifications(écriture des tests unitaires) dans la branche que vous avez crééeà l'étape 3
11. Envoyer votre branche sur votre repository forké et ouvrir un PULL REQUEST où vous allez m'inviter à analyser votre travail

###NB :  Plus il y a des tests, plus vous avez des points.


## Partie II: Test Driven Development (Développement Piloté par les tests)

Dans cette partie, il est question de développer, en utilisant l'approche TDD, une librairie mathématique (Fraction) pour la manipulation des fractions en C#

### Travail demandé 
1. Créer un projet bibliothèque de classe à la racine du repository 
```bash
dotnet new classlib -o Fraction
```

2. Renommer le fichier Class1.cs en Fraction.cs
3. Ajouter ce projet à la solution 
```bash
dotnet sln add ./Fraction/Fraction.csproj
```
4. Créer un projet de test (**FactionTest**) pour la bibliothèque **Fraction**
```bash
dotnet new xunit -o FractionTest
```
5. Renommer le fichier Class1.cs en FractionTest.cs
6. Ajouter ce projet de test à la solution
```bash
dotnet sln add ./FractionTest/FractionTest.csproj
```
7. Ajouter le projet bibliothèque de classe **Fraction** comme une dépendance pour **FractionTest**
```bash
dotnet sln add ./FractionTest/FractionTest.csproj reference ./Fraction/Fraction.csproj
```
8. Écrivez des méthodes dans le projet **FractionTest** permettant de vérifier l'implémentation des opérations sur les fractions qui sera faite dans le projet **Fraction**
9. Variez les méthodes de tests selon différents scénarios ***(Plus de tests plus de points)***
10. Implémenter dans le projet **Fraction** des méthodes pour faire passer tous les tests écrits à l'étape précédente au du **rouge** au **vert**.
11. enregistrer vos modifications dans un commit 
```bash
git commit -am "un commentaire montrant ce que vous avez apporté comme contribution"
```
13. publiez vos modifictions
```bash
git push origin le_nom_de_votre_branche
```
