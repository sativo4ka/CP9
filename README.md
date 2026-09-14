# CP9

Вариант 1. OrderProcessor (обработка заказов)

Входные строки в формате "ID;цена;количество", например "ORDER001;150.50;3".
1. Парсите цена (decimal) и количество (int) через TryParse. Если строка не парсится целиком (неверный формат, нехватка частей после разделения по ;) — залогируйте предупреждение и переходите к следующей строке без исключений.
2. Спроектируйте OrderProcessingException (наследник Exception, три стандартных конструктора) и бросайте его, если цена успешно распарсилась, но оказалась отрицательной — это считается повреждёнными данными, а не опечаткой.
3. Поймайте OrderProcessingException с фильтром catch (OrderProcessingException ex) when (ex.Message.Contains("цена")), залогируйте и продолжите обработку остальных строк.
4. В finally выведите сводку: количество обработанных, успешных и пропущенных заказов.

<img width="1917" height="1076" alt="image" src="https://github.com/user-attachments/assets/8be5aa33-4611-4959-be10-0a963f827bea" />

<img width="1090" height="610" alt="image" src="https://github.com/user-attachments/assets/797b27b5-009f-4247-a12f-e98372437564" />

<img width="1839" height="1341" alt="image" src="https://github.com/user-attachments/assets/9218fd53-b59d-474b-820f-f021524a701c" />
