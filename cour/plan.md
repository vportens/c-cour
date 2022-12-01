## Architecture des application .NET: 7h


	comment architecturer son programme NoCode: 

		1 -notion de classe
			- variable interne
				public/priver
			
			- constructeur
			- function de classe
				getter/setter

		2 -notion de main
			declarer des variable
			declarer des objets de classe
			utiliser les function de la classe
		
		3 -using/namespaces
			notion de namespace pour faciliter l'utilisation des classes creer

		4 -Comment organiser ses classes
			-un objet une classes,
			-une classes un fichiers pour plus de clairete de code
			-la norme : comment ecrire un code pour tous et non uniquement pour soit (code claire et lisible)
		
		5 -Architectur des Application .NET
			-first step, creer un projet avec dotnet new console
				-les fichiers .cs
				-les fichiers .csproj
				-le dossier obj
				-le dossier bin



	difference entre c# et .NET
		c# language de prog
			language de prog phare de Miscroft 
			oriente obj
			utile pour App Web, App Bureau (client lourd), WebServices ...


		.NET framework ici on veux aller jusqu'a Core3 
			ensemble de composent mis en brique donner en outils pour nous faciliter/protocoller l'ecriture de nos programmme
			le socle de base est le clr (common language runtime)
			des outils pour faciliter le developpement d'application Bureau comme WinForm, ASP>NET pour des app web


	difference entre c# et .NET
		c# aura son compilateur qui va nous generer un code intermediaire (MSIL pour Microft intermediaire language)
		et le clr va trad cd code intermediaire en code natif
		l'avantage c'est que le code intermediaire est de pouvoir coder en VB.NET ou f# et d'avoir ce meme code intermediare en msil que le clr va pourvoir interpreter pour l'execution



	biblioqtheque de classes du framework .NET
		manipuler des ficheiers manipuler des listes .tableaux. creer des interfaces graphiques et bien d'autre/


	.NET to .NET Core
		.NET Core est gratuis, opensource 






	architecture des application .Net
	//	a la fin du devellopement de notre app, nous obtenons du code en assembly, qui pourra etre executer par le DLL ou EXE

	organiser les elements de notre programme 
		les Namespace  qui vont contenir des ensembles de classes permet d'organiser notre programme pour plus de clareter
		et permettre de savoir de differencier des classes nomme identiquement dans des namespaces differents
		
		celui le plus courrants va etre le namespace systeme avec toute les fonctions developper par microsoft ()

		les classes 
			les attributs : les donnees
			les methodes : functions




		

## Developpement avec le Framework .NET Core 3: 35h

# day1

Introduction au .NET Core3:

	-Guide d'installation VSCode vs VisualStudio
		tuto utilisation rapide de vscode, ouvrir un dossier/fichier sur vscode, creer un dossier/fichie ect... 
		installation de plugin pour c#,


	-Presentation du .NET Core3
		qu'es ce que .NET Core :
		le language technique: CLR(commonLanguageRuntine), NuGet, notamment
		voir plus, documentation microsoft sur le dotnet

	-Creation d'un programme et execution
		comment creer son programme avec .Net (presentation de Main)
		comment executer son programme  avec .Net
		comment interpreter le retour du programme

				---------------

	-Premier pas, verification des acquits avec rappel, (si non acquits sera integre la de Variable: variable2)
	-Premier programme, notion a presenter: 
		Variable:
			variable en c# premier pas (int, char, string, double/float, decimal, bool);
		Structure de programme:
			namespaces et classes en c#
			structs et difference entre structs et Classes





			variable en c# les tableaux (declarer, initialiser, acceder, iterer), premiere boucle d'iteration, 
			variable en c# 

			
			memoire; declarer, alloue des variable et acces(new, ref), notion garbage collector 


		namespace,
		class (c# un language construit pour faire des class),





# day2

# day3

# day4

# day5


## Presentation des technologies de clients lourds tq WindowsForms, WPF et UWP: 7h

## Tester son code: 14h


## TP validation des acquis: 14h