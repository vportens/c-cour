---
marp: true
paginate: true
theme: gaia

backgroundImage: url(./Ressource/Theme/Diapo.png)
_backgroundImage: url(./Ressource/Theme/Title.png)

---

<link href="./Ressource/Theme/CSS/theme.css" rel="stylesheet">

# Client lourd

---

# Developper en csharp 

---

## Portee du csharp

La puissance du C#;
C'est ca portabilitee.

Le corp de vos fonctions, de vos methodes, peuvent etre utilise pour des applications Bureau, Web, Telephone, Console.


---

## Du code dans un IDE au application Bureau

Pour le moment, vous n'avez vu que du code sur VSCode, 
mais c'est ce meme code qui va etre porte sur le Bureau et c'est ce que nous allons voir.

---

# Rappel



---

# Un des interets du framework .Net 

---

## Plateform .Net, les environnements ASP.NET et Winforms

L'interet des CLR (Common Language Runtime).

Le CLR est un interpréteur qui permet d'executer du code sur plusieurs plateformes.

Il est le moteur de la plateforme .Net, il permet de faire des applications qui fonctionnent sur plusieurs plateformes, sans avoir a reecrire le code.

---

## Plateform .Net, les environnements ASP.NET et Winforms

Le CLR est un compilateur qui compile le code C# en code machine pour les plateformes suivantes :

- Windows
- MacOS
- Linux
- Android
- IOS

---

## Rappel des bibliothèque de classe avec .Net

Les bibliotheque de classe comme `System`, fonctionne grace a la portabilite de .NET

---

# Le code pour les App, notaments les App de Bureau (client lourd)

---

## WF, WPF, UWP, des logiciels pour windows

Le resultat de la compilation du code va etre utiliser par differentes application, qui vont integrer des outils suplementaire pour affichier de maniere graphique le code.


---

Window Forms; 
Windows Presentation Foundation; 
Universal Windows Platform;

Ce sont les trois grandes applications developpe par microsoft pour le developpement d'application Bureau.

Elles ne sont disponible que sur Windows.

---

## Porter un code sur ces logiciels

Le code etant le meme, il suffit de changer la bibliotheque de classe et les outils d'affichage graphique pour integrer le code dans les applications.

---

# Window Forms

---

## Introduction : Un outils qui remplace le model vu-controleur

Le model vu-controleur, tres util dans les annees 90, a ete remplace par un outils plus simple a utiliser.

Le drag and drop de widget, la modification des proprietes des fenetre avec un fichier de configuration simple.


Voici les solutions apportes par ces outils 





---

## Outil de developpement apporte

Le logiciel permet : 
- creer une application graphique,
- des fenetre, 
- des bouttons, 
- des labels, 
- des images, 
- des boites a cocher, 
- des champs de texte, 

---

### La fenetre de votre applicaton

Tout les interactions que vous connaisez,
Auquelles vous etez habituees avec la fenetre d'une application sont presentes.

---

### La fenetre de votre applicaton

- ColorBackground
- Resize
- Icon
- Opacite
- Clic droit pour ouvrir un menu
- ect...

---

### Les objects pour acceuillir vos classes et  methodes

Il est possible d'ajouter des objects pour acceuillir vos classes et methodes, 

C'est a dire, des object qui vont contenir votre code.

---

Vous pouvez choisir et modifier le comportement, avec 


- Boutton
- Label
- Image
- Boite a cocher
- Champ de texte

---
<!-- image du logiciel -->

---

# Windows Presentation Foundation

---

## Heritage de Window Forms 

Windows Presentation Foundation herite de Window Forms.
Tout les outils cite precedement sont disponibles sur WPF.

Evidement l'outils apporte quelques avancees, et correction sur les outils de bases mal implemente.


---

# Les ajouts comparer a WF pour les clients lourd

---

### Vectorialisation des objects

La creation des objects devient vectoriel dans l'application.

On ne parle plus de position en pixel mais de position absolue (pourcentage de la fenetre)

---

## Au dela du logiciel de Bureau une ouverture sur l'application Web

WPF permet de creer des applications de bureau, mais il est possible de l'utiliser pour creer des application Web.


Les applications Web, nommées XBAP (Xaml Browser Application,  XAML Browser Applications), 
Sont des programmes qui tournent dans Internet Explorer ou Firefox, sous Windows ou Mac OS (sous GNU/Linux la plate-forme s'appelle MoonLight)

---


### Securite des donnees et de l'os

Par défaut, ces applications n'ont pas accès au système de fichiers pour la sécurité des données et du système d'exploitation.

Ceci permet, par exemple, de faciliter le déploiement d'un logiciel sur un grand nombre de machines.

---

### Gestion des bases de donnees et Presentation

WPF gère les bases de données pour les applications ou le web et fournit des modèles de présentation.

---

# Universal Windows Platform



---


## Une avancer suplementaire dans le developpement 

Cross Platform sous Windows 10

Dans la course a la portabilite du code, UWP continue dans la lance.

L'objectif de cette plate-forme logicielle est d'aider à développer des applications universelles qui fonctionnent sous Windows 10,



---

### Un outils pour Bureau, Mobil, console Microsoft

Windows 10 Mobile, Xbox One et Hololens.
Ce sont maintenant la portee du code sans qu'il y ait le besoin de réécrire un nouveau code source pour chacun de ces systèmes.


---

### Un outils plus supporter

Malheureusement l'outil n'est plus supporte.

---


# Presentation Code et interface (CL) Etape par Etape avec une App WinForms

<!-- TODO ajouter des images -->
---

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/fenetreWinForms.png)



---


## Propriete de votre fenetre, l'essentiel

Une toolbox est mis a disposition sur WF pour la gestion des parametres de propriete de la fenetre.

On ne passera donc pas par le code directement.


---

### Personnaliser le nom

La personnalisation ce fait aisement.
L'outils ci-dessous permet de changer le nom de la fenetre sur WinForms.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/NameWindow.png)


La prevus de l'applicaton nous montre les changements effectif de la fenetre, ici le nom correspond bien a celui choisit.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/NameWindow2.png)


---



#### Color

La fenetre peut avoir un background personnalise, notamment changer la couleur avec cette outil.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/backColorWindows.png)

---

#### Image

Il est possible de mettre un image en background de votre fenetre.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/backImageWindows.png)

---

### Opacite de la fenetre

De plus vous pouvez choisir l'opacite de la fenetre

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/Opacity.png)

---

### Resize la fenetre

Definir la possibilite de l'utilisateur de changer la taille de la fenetre.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/resizeAuto.png)

---

#### Une Taille minimun

Definir la taille minimal de l'ecrant.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/DefMinSize.png)

---

#### Une Taille maximun

Definir la taille maximal de l'ecrant.


![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/DefMaxSize.png)


---

### La scrolle bar

L'outils permettant d'activer la scrolle bar :


![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/Scrollbar.png)

---


### Le curseur
Outils de configuration pour modifier l'apparence du curseur.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/CursorApparence.png)

---

# Des outils pour acceuillir les fonctions


---

## La tool box

Les differents outils disponibles


![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/toolBoxFunction.png)

---

## Les object pour acceuillir vos classes et methode

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/toolBoxFunction.png)

---

## Quand appyer sur un boutton appel une methode

Le boutton : 

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/Button.png)

---

Le boutton dans le code, pour que l'interaction ce passe il faut mettre le code dans la fonction.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/interactionButtonCode.png)

---

# Finalite, presentation d'une App de Bureau sous Winforms fonctionnelle.


