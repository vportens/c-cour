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

# Développer en csharp  

---

## Portée du csharp

La puissance du C#;
C'est ca portabilités.

Le corps de vos fonctions, de vos méthodes, peuvent être utilise pour des applications Bureau, Web, Telephone, Console.


---

## De l'IDE a l'application Bureau

Pour le moment, vous n'avez vu que du code sur VSCode, 
mais c'est ce même code qui va être porte sur le Bureau et c'est ce que nous allons voir.

---

# Rappel



---

# Un des interets du framework .Net 

---

## Plateforme .Net, ASP et Winforms

l’intérêt des CLR (Common Language Runtime).

Le CLR est un interpréteur qui permet d’exécuter du code sur plusieurs plateformes.

Il est le moteur de la plateforme .Net, il permet de faire des applications qui fonctionnent sur plusieurs plateformes, sans avoir a réécrire le code.

---

## Plateforme .Net, ASP et Winforms

Le CLR est un compilateur qui compile le code C# en code machine pour les plateformes suivantes :

- Windows
- MacOS
- Linux
- Android
- IOS

---

## Rappel des bibliothèques avec .Net

</br>

</br>

Les bibliothèque de classe comme `System`, fonctionne grâce a la portabilité de .NET

---

# Le code pour les App, notamment les App de Bureau (client lourd)

---

## WF, WPF, UWP

Le résultat de la compilation du code va être utiliser par différentes application, qui vont intégrer des outils supplémentaire pour afficher de manière graphique le code.


---

## Des logiciels Windows

- Window Forms; 
- Windows Presentation Foundation; 
- Universal Windows Platform;

Ce sont les trois grandes applications développe par microsoft pour le développement d'application Bureau.

Elles ne sont disponible que sur Windows.

---

## Porter un code sur ces logiciels

Le code étant le même, il suffit de changer la bibliothèque de classe et les outils d'affichage graphique pour intégrer le code dans les applications.

---

# Window Forms

---

## Introduction : Un outils qui remplace le model vu-controleur

Le model vu-controleur, très util dans les années 90, a ete remplace par un outils plus simple a utiliser.

Le drag and drop de widget, la modification des propriétés des fenêtre avec un fichier de configuration simple.


Voici les solutions apportes par ces outils 





---

## Outil de développement apporte

Le logiciel permet : 
- créer une application graphique,
- des fenêtres, 
- des boutons, 
- des labels, 
- des images, 
- des boites a cocher, 
- des champs de texte, 

---

## La fenêtre de votre application


</br>

</br>

Tout les interactions que vous connaissez,
Auxquelles vous êtes habitués avec la fenêtre d'une application sont présentes.

---

## La fenêtre de votre application

- ColorBackground
- Resize
- Icon
- Opacite
- Clic droit pour ouvrir un menu
- ect...

---

## Les objects WF

Il est possible d'ajouter des objects pour accueillir vos classes et méthodes, 

C'est a dire, des object qui vont contenir votre code.

---

## Les objects WF

Vous pouvez choisir et modifier le comportement, avec 


- Bouton
- Label
- Image
- Boite a cocher
- Champ de texte

---
<!-- image du logiciel -->

---

# Windows Presentation Foundation

---

## Héritage de Window Forms  

Windows Presentation Foundation hérite de Window Forms.
Tout les outils cite précédemment sont disponibles sur WPF.

Évidement l'outils apporte quelques avancées, et correction sur les outils de bases mal implémenté.


---

# Les ajouts comparer a WF pour les clients lourd

---

## Vectorisation des objects

La creation des objects devient vectoriel dans l'application.

On ne parle plus de position en pixel mais de position absolue (pourcentage de la fenêtre)

---

## Au delà du logiciel de Bureau une ouverture sur l'application Web

WPF permet de créer des applications de bureau, mais il est possible de l'utiliser pour créer des application Web.


Les applications Web, nommées XBAP (Xaml Browser Application,  XAML Browser Applications), 
Sont des programmes qui tournent dans Internet Explorer ou Firefox, sous Windows ou Mac OS (sous GNU/Linux la plate-forme s'appelle MoonLight)

---


## Sécurité des données et de l'os

Par défaut, ces applications n'ont pas accès au système de fichiers pour la sécurité des données et du système d'exploitation.

Ceci permet, par exemple, de faciliter le déploiement d'un logiciel sur un grand nombre de machines.

---

## Gestion des bases de données et Presentation

WPF gère les bases de données pour les applications ou le web et fournit des modèles de présentation.

---

# Universal Windows Platform



---


## Une avancer supplémentaire dans le développement    

Cross Platform sous Windows 10

Dans la course a la portabilité du code, UWP continue dans la lance.

L'objectif de cette plate-forme logicielle est d'aider à développer des applications universelles qui fonctionnent sous Windows 10,



---

## Un outils pour Bureau, Mobil, console Microsoft

Windows 10 Mobile, Xbox One et Hololens.
Ce sont maintenant la portée du code sans qu'il y ait le besoin de réécrire un nouveau code source pour chacun de ces systèmes.


---

## Un outils plus supporter

Malheureusement l'outil n'est plus supporte.

---


# Presentation Code et interface (CL) Etape par Etape avec une App WinForms

<!-- TODO ajouter des images -->
---
<!-- _backgroundImage: url(./Ressource/Theme/Flat.png) -->
![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/fenetreWinForms.png)



---


## Propriété de votre fenêtre, l'essentiel

Une toolbox est mis a disposition sur WF pour la gestion des paramètres de propriété de la fenêtre.

On ne passera donc pas par le code directement.


---

## Personnaliser le nom

La personnalisation ce fait aisément.
L'outils ci-dessous permet de changer le nom de la fenêtre sur WinForms.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/NameWindow.png)

---


## Personnaliser le nom

La prévus de l’application nous montre les changements effectif de la fenêtre, ici le nom correspond bien a celui choisit.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/NameWindow2.png)




---



## Color

La fenêtre peut avoir un background personnalise, notamment changer la couleur avec cette outil.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/backColorWindows.png)

---

## Image

Il est possible de mettre un image en background de votre fenêtre.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/backImageWindows.png)


---

## Opacite de la fenêtre

De plus vous pouvez choisir l'opacite de la fenêtre

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/Opacity.png)

---

## Resize la fenêtre

Définir la possibilité de l'utilisateur de changer la taille de la fenêtre.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/resizeAuto.png)

---

## Une Taille minimum

Définir la taille minimal de l’écran.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/DefMinSize.png)

---

## Une Taille maximum

Définir la taille maximal de l’écran.


![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/DefMaxSize.png)


---

## La scroll bar

L'outils permettant d'activer la scrolle bar :


![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/Scrollbar.png)

---


## Le curseur
Outils de configuration pour modifier l'apparence du curseur.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/CursorApparence.png)

---

# Des outils pour accueillir les fonctions

dd

---

## La tool box

Les différents outils disponibles


![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/toolBoxFunction.png)

---

## Les object pour accueillir vos classes et méthode

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/toolBoxFunction.png)

---


## Quand appuyer sur un bouton appel une méthode

Le bouton : 

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/Button.png)


---
<!-- _backgroundImage: url(./Ressource/Theme/Flat.png) -->
Le bouton dans le code, pour que l'interaction ce passe il faut mettre le code dans la fonction.

![](./Ressource/picsWinForm/Captures%20d%E2%80%99%C3%A9cran/interactionButtonCode.png)

---

# Presentation d'une App de Bureau sous Winforms fonctionnelle.


