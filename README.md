# jcszr8-ASP.NET-Core-obsluga-bledow-i-wyjatkow

1. Zwalidować input od użytkownika - trzeba złapać wyjątek FormatException (na razie nie korzystamy z try parse);
2. Metoda Close() klasy MagicCalculator musi zostać wykonana, nawet jeśli zostanie rzucony wyjątek.
3. Metoda CalculateMagicNumber powinna działać tylko dla liczb od 1 do 100. (ArgumentException);
4. Wszystkie wyjątki powinny być łapane w metodzie Main klasy Program.
4. Metoda Step1 powinna rzucić wyjątek InvalidOperationException dla seed = 50.
5. Klasa MagicCalculator z poziomu metody CalculateMagicNumber powinna zapisywać do pola Errors wszystkie błędy.
6. Metoda Step1 powinna wywołać metodę Step2 (jako parametr wykorzystaj to co obliczyła metoda Step1).
7. Metoda Step2 powinna rzycić wyjątek NotImplementedException, jeśli sekunda jest większa od 30.
8. Wszystkie typy wyjątków, które zostały wykorzystane, powinny być osobno obsłużone w metodzie main.
9. Refaktoring - wykorzystujemy TryParse do przyjmowania inputu od użytkownika.