---
marp: true
paginate: true
theme: gaia

backgroundImage: url(../../../Ressources/Theme/Diapo.png)
_backgroundImage: url(../../../Ressources/Theme/Title.png)
---

<link href="../../../Ressources/Theme/CSS/theme.css" rel="stylesheet">

<!-- _backgroundImage: url(../../../Ressources/Theme/Title.png) -->

# Exercice Reference

---

## Exercice - 1 Swap

```csharp
int one = 1;
int two = 2;

void    swap(ref int a, ref int b)
{
    int tmp = a;
    a = b;
    b = tmp;
}

swap(ref one, ref two);
Console.WriteLine("one = " + one + " two = " + two);
```

---

## Exercice - 2 Divise_modulo

```csharp
int a = 1012;
int b = 5;
int rest = 0;

int divise_modulo(int a, int b, ref int rest) {
    rest = a % b;
    return a / b;
}

int ret = divise_modulo(a, b, ref rest);
Console.WriteLine("resultat de la division: " + ret);
Console.WriteLine("rest: " + rest);
```