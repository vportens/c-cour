---
marp: true
paginate: true
theme: gaia

backgroundImage: url(../../../Ressources/Theme/Diapo.png)
_backgroundImage: url(../../../Ressources/Theme/Title.png)
---

<link href="../../../Ressources/Theme/CSS/theme.css" rel="stylesheet">

<!-- _backgroundImage: url(../../../Ressources/Theme/Title.png) -->

# Correction tableaux 
---

## Exercice 2

```csharp

int nbr = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[] tab = new int[nbr];

for (int i = 0; i < nbr; i++)
{
    tab[i] = rand.Next(1, 100);
}

Array.Sort(tab);
```

---

## Exercice 2 suite


```csharp

for (int i = 0; i < nbr; i++)
{

    if (tab[i] >= 44 && tab[i] <= 77)
       Array.Clear(tab, i, 1);
}

for (int i = 0; i < nbr; i++)
{
    Console.WriteLine(tab[i]);
}
```


---


## Exercice 4

```csharp

int nbr = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[] tab = new int[nbr];

for (int i = 0; i < nbr; i++)
{
    tab[i] = rand.Next(1, 10);
}
```

---

## Exercice 4 suite

```csharp
int idx = 0;
while (idx < tab.Length) {
    int j = 0; 
    while (j < tab.Length){
        if (j != idx && tab[idx] == tab[j] && tab[idx] != 0)
            Array.Clear(tab, j, 1);
        j++;
    }
    idx++;
}
Console.WriteLine("Tableau sans doublons : ");
for (int i = 0; i < nbr; i++) {
    Console.WriteLine(tab[i]);
}
```

---

## Exercice 4 suite

```csharp
int nbrDoublons = 0;
for (int i = 0; i < nbr; i++) {
    if (tab[i] == 0)
        nbrDoublons++;
}

int[] copytab = new int[nbr - nbrDoublons];

int k = 0;
for (int i = 0; i < nbr ; i++) {
    if (tab[i] != 0) {
        copytab[k] = tab[i];
        k++;
    }
}
```

---

## Exercice 4 suite

```csharp
Console.WriteLine("Tableau copy : ");

for (int i = 0; i < copytab.Length; i++)
{
    Console.WriteLine(copytab[i]);
}
```