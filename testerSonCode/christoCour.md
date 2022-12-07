---
marp: true
theme: default
paginate: true

backgroundImage: url(./ressources/diapo.png)

_backgroundImage: url(./ressources/title.png)
---

<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@700&display=swap" rel="stylesheet">

<link rel="stylesheet" type="text/css" href="./ressources/file.css" />

---

# Introduction

Quels sont les besoins d'un développeur ?

-   **Tester** son code
-   **Documenter** son code
-   **Maintenir** son code

Le **TDD** (Test Driven Development) est une méthode de développement qui permet de répondre à ces besoins, en plus de permettre de **développer** plus rapidement.

---

# Qu'est ce que le TDD ?

TDD : Test Driven Development

Les principes du TDD:

-   **Ecrire** un test
-   **Ecrire** le code pour que le test passe
-   **Refactoriser** le code

---

# Le cycle red-green-refactor

Le cycle red-green-refactor vous guidera dans l'écriture de vos tests.

red : Vous écrivez un test qui échoue, car le code n'est pas encore implémenté.(Le resultat sera rouge)

green : Vous écrivez le code pour que le test passe. (Le resultat sera vert)

Refactor : Vous refactorisez votre code pour le rendre plus lisible et plus maintenable. (Le resultat doit rester vert)

---

<style scoped>
img{
	position: absolute;
	width: 65%;
	top: 15%;
	left: 10%;
}
	</style>

![](./ressources/tdd.png)

---

# Test unitaire

Soumettre une partie de code à un test

Il permet la mise en place d'un **contrat** entre le développeur et le client.

Ou le client peut :

-   **Tester** le code
-   **Quantifier** la qualité du code
-   **maintenir** le code
-   **sécuriser** le code

---

# exemple de test

Demande du client : "Je veux que la fonction `add` retourne la somme de deux nombres"

```csharp
public class Test {

	public void testAdd() {
		Calculatrice calculatrice = new Calculatrice();
		int resultat = calculatrice.add(1, 2);
		Console.WriteLine("resultat         = " + resultat);
		Console.WriteLine("resultat attendu = 3");
	}
}
```

---


# problematique de tests

-   la lisibilité des résultats
-   la complexité des tests
-   la maintenance des tests
-   la répétition des tests

---