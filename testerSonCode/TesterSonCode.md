---
marp: true

---
# TesterSonCode

---

# Quel sont les besoin d'un developpeur

---

## Introduction 
Lorsque l'on demande un produit a un developpeur, celui ci doit s'assurer de rendre un travail fonctionnel.

Il doit aussi repondre au demande du client et produire un produit claire, scalable, et utilisable par d'autre que lui.

Il sera donc necessaire pour vous d'automatiser le test de votre code, une depense de temps qui vous en rapportera toujours plus que ce qu'il vous aura couter.



---

# Pourquoi tester son code

---

## Pour vous

---

### Assurer que votre fonction fonctionne

Dans un premier temps,
Il serait bien vu que vos fonctions remplisse leurs objectifs principale.

Il serait dommage que l'utilisateur ayant un besoin precit et delegant sa charge de travail;
grace a vos outils, n'atteigne pas ses objectifs.

Ou bien meme vous; reutilisant votre code, cela pourrait avoir un effet boule de neige. Vous donnant des heures et des heures de travail pour trouver l'erreur.

Il est de bonne habitude de toujours tester son code.


---

### Securiser votre code

Tester permet aussi de se rendre compte de potentielles erreurs en cas d'argument invalide, d'overflow mal gerer, ou bien des condition non proterge.


---

## Pour le client

---

### Assurer la robustesse du code

Le code subbit de nombreux tests, et pour le client, ca montre que le produit fonctionne.

Il est mit a l'epreuve et apportera de la confiance en l'outil pour le client.


---

### Valider chaque demande Client

Par ailleur le client vous demendera toujours des choses bien specifique. 

Lorsque celui verra les batteries de tests, une confiance dans le produit et directement votre travail ce creera.

Car il n'est pas necessaire que le client code.
Et meme si c'est le cas;
Les tests permets de valider le cahiers des charges de maniere bien plus elegante et plus sure pour les 2 partis.

---


# Tester son code 

---

## Documenter son code
L'avantage de la documentation, c'est une approche et une utilisation de l'outils de maniere plus simple.

Ce ne sera pas toujours le cas. En realite, il y aura beaucoups de moment ou le code ne sera pas documenter.

Tester le code permet de ce rendre compte des points fort et faible de celui-ci. Et une utilisation plus juste.

---

## Maintenir son code

Votre code evolue.
C'est un fait, que vous y touchiez ou non, les technologies de developpement evolues et par concequent le code base sur celui-ci evolue avec.

Avoir une base de test permet de verifier si votre code est toujours stable, et fonction tel que vous le souhaitez.

Quand vous y apporterais des modifications, vous voudrez rajouter des implementations ca sera encore plus vrai.

En changeant / rajoutant du code dans vos classes, il se peut que certaines fonctionnaliter casse. 

Vos tests permette de surveiller cas de maniere automatique. Et ne pas avoir a toujours tout tester a la main.

---


# Qu'est ce que la TDD


Test Driven Developpement

---

## Principe du TDD

Le principe du TDD est simple. Il consiste a ecrire un test avant d'ecrire le code.

Ainsi, on s'assure que le code que l'on va ecrire est bien celui qui est attendu par le test.

Il y a donc 3 etapes a suivre.

---


### Ecrire un test

Ecrire un test permet de definir les besoins du code.

C'est une etape primordiale dans le developpement d'un projet.

---

### Ecrire un code qui passe le test

Apres avoir ecris le test, il faut ecrire le code qui permettra de passer ce test.



### Refactoriser le code

Lorsque le code passe le test, il faut reflechir a comment ameliorer le code.

Le but est de le rendre plus lisible, plus simple, et plus rapide.

---

### La boucle recommence

Votre code passe votre test.

Il faut ecrir plus de test, et recommencer les etapes tout en fesant que les tests precedents continue de fonctionner.

Une fois tout les besoins tester, vous aurez correctement tester votre code.

---

# Cycle RGR (Red-Green-Refactor)

Le cycle red-green-refactor vous guidera dans l'écriture de vos tests.

red : Vous écrivez un test qui échoue, car le code n'est pas encore implémenté.(Le resultat sera rouge)

green : Vous écrivez le code pour que le test passe. (Le resultat sera vert)

Refactor : Vous refactorisez votre code pour le rendre plus lisible et plus maintenable. (Le resultat doit rester vert)

<!-- TODO mettre l'image de rgr -->
---

## Test unitaire

Soumettre une partie de code à un test

Il permet la mise en place d'un contrat entre le développeur et le client.

Ou le client peut :

- Tester le code
- Quantifier la qualité du code
- maintenir le code
- sécuriser le code

---


## Soumettre une partie du code a des tests unitaire


## Le test unitaire pour le client
## Exemple de test

# Problematique de test

## Lisibilite des resultats
## Complexite des tests
## Maintenance des tests
## Repetition des tests

# Une solution : Xunit
## Gain de temps
## Gain de productivite
## Gain de qualite
## Gain de maintenabilite

# Qu'est ce que Xunit
## Dotnet et Xunit
## Extension VSCode pour Xunit

# Pourquoi utiliser Xunit?
## Xunit est simple d'utilisation
## Tres populaire
## Scalable sur toutes les versions de dotnet et tout les environnements de travail

# Installation de Xunit
## Xunit deja present avec dotnet

# Installaton exentension VSCode

# Creer un fichier de test
## Les commandes

# La terminologies
## Test Unitaire
## Cas de test
## Suite de test


# Test unitaite
## Quoi tester
### Methode de la Classes
### Conditions de la classe
### Comportement de la classe
### Tout les chemins possible

## A eviter
### Getter / Setter

# Principe Assertion

# Classes Assert pour les tests
## Equal
## NotEqual
## NotSame
## Contains
## DoesNotContains
## InRange
## FALSE
## Empty
## TRUE
## IsType

# Mot clef 
## [Fact]
## [Theory]
## [InlineDate]

# La couverture du code

# Repetetions des tests