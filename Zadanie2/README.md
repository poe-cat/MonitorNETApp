# Kalkulator

Prosty kalkulator z graficznym interfejsem użytkownika (Windows Forms).

Umożliwia wykonywanie czterech podstawowych operacji arytmetycznych: `+`, `-`, `*`, `/` oraz wyświetlanie wyniku.

## Funkcje

- Przyciskowe wprowadzanie cyfr (0–9)
- Obsługa operacji: `+`, `-`, `*`, `/`
- Obsługa `=` (wynik) i `C` (wyczyść)
- Pole wyświetlające bieżące wartości i wynik

## Wymagania

- Visual Studio 2022 lub nowszy
- .NET 6/7/8 z Workload: **.NET Desktop Development**
- System Windows (aplikacja WinForms)

## Uruchomienie

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/twoj-login/KalkulatorApp.git
   ```

2. Otwórz plik `KalkulatorApp.sln` w Visual Studio

3. Kliknij **Start (F5)** lub zbuduj i uruchom ręcznie

## Pomiar czasu uruchomienia

Aplikacja mierzy czas inicjalizacji (od `Main()` do końca `InitializeComponent()`).

Jeśli czas startu przekroczy 3000 ms, do **Dziennika zdarzeń systemu Windows** dodawany jest wpis typu `Warning` o zbyt długim uruchomieniu.

Aby przetestować ręcznie: wstaw `Thread.Sleep(4000);` na początku konstruktora `Form1()`.

## Jak sprawdzić dziennik zdarzeń?

1. `Win + R` → wpisz `eventvwr`  
2. Otwórz: **Dzienniki systemu Windows → Aplikacja**  
3. Szukaj źródła: `KalkulatorApp`

## Struktura projektu

```
KalkulatorApp/
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── KalkulatorApp.csproj
KalkulatorApp.sln
.gitignore
README.md
```


