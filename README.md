# Приложение "BookStorage"
_______
# Содержание:
________
# 1 Введение
________
______
### 1.1 Назначение
В этом документе описаны функциональные и нефункциональные требования к desktop-приложению "BookStorage". Основное назначение приложения - хранение коллекции прочитанных книг и поиск книг в каталоге.

### 1.2 Аналоги

  - All My Books: существует пробная версия на 30 дней, для дальнейшего использования нужна 
   лицензия.
  
  - Calibre

# 2 Требования пользователя
_____
______
### 2.1 Программные интерфейсы
___
 - Framework: .Net Framework 4.6.1
 - Programming language: C#, XAML

### 2.2 Интерфейс пользователя 
____
#####  2.2.1 Главная страница
 - Add...  - добавить новую книгу в каталог.
 - Delete  - удалить выбранную книгу из каталога.
 - Help - Открыть текстовое окно с пояснением работы приложения
 - About - Информация о программе.
  
##### 2.2.2 Окно "New Book"

##### 2.2.3 Окно Help 
 
##### 2.2.4 Окно About

### 2.3 Классы пользователей
____
| Класс пользователей | Описание |
| ------ | ------ |
| Анонимные пользователи | Пользователи, которые добавляют книги без подписи.Могут свободно добавлять книги и просматривать их. |
| Подписавшиеся пользователи | Пользователи, подписавшиеся при добавлении книги(такие книги можно искать по пользователю, добавившему книгу). Возможности работы с приложением аналогичны анонимным пользователям. |

# 3 Cистемные требования 
______
______
### 3.1 Функциональные требования 
_____
##### 3.1.1 Основные функции:
 1) Просмотр каталога книг.
 >Возможность просматривать книги, добавленные в каталог.

 2) Поиск книг через поисковую строку и через критерии поиска.
 >Возможность искать книги по конкретному названию книги при помощи поисковой строки (или по части названия: в этом случае будут выведены все книги, удовлетворяющие введённому тексту).  Добавочно можно указать критерии поиска книг: пользователя, добавившего книгу; жанр; время добавления. 
 
 3) Добавление новой книги в каталог.
 >Возможность добавлять прочитанные книги и указать своё имя  и жанр книги при её добавлении.
 4) Удаление книги из каталога.
 >Существует возможность удаления книги из каталога книг(причины удаления могут быть разные: вдруг вы подумали, что прочитали всю книгу, а это был лишь один рассказ из книги.)
 
### 3.2 Нефункциональные требования
____
##### 3.2.1 Атрибуты качества
Все функциональные элементы пользовательского интерфейса проименованы. Таким образом, пользователям легко ориентироваться в приложении даже без пункта Help.
##### 3.2.2 Внешние интерфейсы 
Весь текст в приложении относительно крупный, что довольно хорошо для людей с плохим зрением + интерфейс приложения - светлый, что ещё больше улучшает видимость элементов интерфейса.
##### 3.2.3 Обработка исключительных ситуаций
1) Если пользователь добавляет книгу, которая уже есть в каталоге(имя пользователя совпадает), то приложение выводит окно с сообщением : "Sorry, but this book has already been added".
2) В случае непредвиденной ошибки, приложение обязательно(!) выведет сообщение: "ERROR! Unknown mistake has appeared. Let me know if it has happened writing me on cant_fix_it@mail.ru".
 

