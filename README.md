# Team and project
## 15/gameName

## Team members list 
1. > Анісімов Є.О - **team leader**
1. > Сов'як В.Б.
1. > Гоголь А.О.
1. > Томенко Н.Д.
1. > Бачинська К.В.

## Unity version
> 2021.3.11f1

# Lab
## About team task management (screenshot/description)
![alt text](https://github.com/Zhenyettta/basedGame/blob/main/Images/taskManager.png)

*To Do:* список запланованих features.

*In Progress:* список features, які розробляються.

*Complete:* список features, які є розробленими, але ще не тестованими.

*Test:* список features, які знаходяться в тестуванні.

*Done:* список features, які є завершеними.

## Chosen games analysis

### Dota 2
*Учасник команди:* Анісімов Є.О.

*Жанр:* MOBA (Multiplayer Online Battle Arena).

*Ціль гри:* Знищити ворожий трон (Ancient), тим самим, виграти гру. Трон - це головна спорудна, наявна у кожної команди, знаходиться на 2 кінцях карти по середній лінії(міду, про який згодом). 

*Cистема локацій:* У грі присутня одна єдина карта, поділена річкою по діагоналі. Присутні 3 лінії з кожної сторони - верхня, нижня і середня. На кожній лініїї присутні різні спорудження: Вежі, а за ними бараки, біля яких спавняться кріпи, які йдуть по лініям, але про це згодом. Ландшафт карти може змінюватись з випуском патчів.

![alt text](https://github.com/Zhenyettta/basedGame/blob/develop/Images/Minimap_7.29.webp)

*Формат гри:* Основний 5 на 5 з можливістю вибору персонажу (бувають різні формати гри). В грі присутні 2 сторони: сили світла - Radiant та протилежні сили темряви - Dire.

*Система персонажів:* В грі присутні 123 героя, поділених за основним атрибутом: спритність, сила та інтелект, від кожного з них залежать можливості героя та його характеристики. 
![alt text](https://github.com/Zhenyettta/basedGame/blob/develop/Images/Screenshot_2.png)
В кожного героя присутні унікальні скіли, механіки, пасивні можливості, дерево талантів та інше, що додає складності в розуміння гри новачкам. 
![alt text](https://github.com/Zhenyettta/basedGame/blob/develop/Images/Screenshot_1.png)

*Система предметів:* В грі наявно багато предметів, які можна поділити на 2 основні категорії: ті, які можна купити в магазині та ті, які випадають з нейтральних кріпів, які спавняться в лісі на своїх виділених місцях. Також існує Aegis of the Immortal, предмет який дає 2 життя, отримати його можна, вбивши Рошана, найсильнішого кріпа в грі. Нейтральні предмети діляться на 5 ступеней. Кожен з них випадає після деякої хвилини гри. 1 - 7.00, 2 - 17.00, 3 - 27.00, 4 - 37.00, 5 - 60.00. Кожна команда може мати до 5 нейтральних предметів кожного ступеню одночасно, є можливіть викрадати чужі нейтральні предмети, які не підібрали з землі. Кожен персонаж має унікальний item build, тобто предмети, які йому підходять, варіативність предметів додає грі складності.
![alt text](https://github.com/Zhenyettta/basedGame/blob/develop/Images/Screenshot_3.png)

*Особливості гри та геймплею:* Дота 2, на відміну від інших ігор, має доволі розвинути систему рангового підбору гри. Кожен гравець має свій рейтнг, так званий MMR(Match Making Rating), чим більше - тим краще. За перемогу дають 30 одиниць рейтингу, якщо ти граєш один та 20, якщо ти граєш в команді(party).
В доті присутні одиниці поведінки, максимальне значення 10000. Якщо на тебе скаржились інши гравці, або система помічала AFK (Away from keyboard) або покидання матчу, тоді одиниці поведінки будуть зменшуватись. Також існує режим "Low priority", куди кидають гравців, які погано себе вели. В цьому режимі дотсупні на вибір будуть тільки 3 героя, по герою з кожного атрибута, і тобі доведеться грати з такими ж правопорушниками, як і ти. Звичайний підбір, як союзників так і ворогів, базується на одиницях MMR, поведінки та вибраного регіону.
Існують 2 види кріпів, нейтральні та лінійні. Перші спавняться в лісі на виділених місцях (кемпах) кожну хвилину, якщо у виділеному місці немає нікого. Ця механіка дозволяє стакати кемпи, тобто, якщо ти вдариш нейтрального кріпа, він та всі його друзяки, побіжуть за тобою, тож коли вони вийдуть за радіус кемпа, там з'являться нові кріпи і кемп буде стакнутий. Такі речі роблять в основному сапорти для 1, 2 або 3 позиції. Другі ж, кожні 30 секунд спавняться біля бази та йдуть по лініям, поки не зустрінуться і не почнуть місити один одного. Золото дається саме за добивання кріпа, одиниці досвіду даються всім хто був поруч.

Також треба відмитити ком'юніті доти 2. На мою думку це найкраще та найдружелюбніше ком'юніті в світі, всі гравці поважають один одного, в команді завжди підтримується позитивний настрій та жага до перемоги. 

В грі існує 5 позицій, від 1 до 5. Обговоримо їх детальніше.
* 1 - Кері (Carry) Головна позиція в команді. Ціль цієї позиції, отримати багато золота (про золото пізніше), купити багато предметів, вбивати ворогів, допомогти команді зламати трон. З самого початку гри йде на легку лінію (На картинці нижче показано), її легкість полягає в тому, що кріпи які йдуть по лініям зустрічаються ближче до вежі, яка наносить шкоду, всім кого бачить та дає додаткову броню союзному герою. 
* 2 - Мід (Mid) Герой який йде на середню лінію. Основна ціль дати space (вільне місце), своєму кері, щоб той зміг спокійно фармити(бити кріпів і отримувати з них золото). Доволі активна позиція.
* 3 - Оффлейнер (Offlane) Герой, який йде на складну лінію (Кріпи зустрічаються далі від його вежі). Герої цієї позиції потребують багато сили та здоров'я, оскільки його основна ціль - заважати ворожому кері отримувати золото, а в мід геймі(середина гри і далі) ініціювати стички між персонажами.
* 4 - Часткова підтримка (Soft support) Гравець підтримки, який стоїть на лінії разом з оффлейнером. Активна роль, яка повинна разом з оффлейнером заважати ворожому кері, а потім допомогати своїм союзникам по всій карти.
* 5 - Повна підтримка (Harf support) Гравець підтримки, який на стоїть на лінії разом з кері. Менш активна роль, основна ціль якої, дати можливіть союзному кері отримати багато золото з стадії лейнінгу (Початок гри, коли герої стоять на лініях). А потім, робити певні речі на карті, ставити варди (штучки які дозволяють бачити карту) та інше.

![alt text](https://github.com/Zhenyettta/basedGame/blob/develop/Images/Minimap_New7.29.jpg)

В доті 2 існує Навчання, щоб навчитись грати на базовому рівні, та Глосарій з майже усією теоретичною складовою гри, оскільки механік в грі ще тьма і тьма. З досвідом приходить розуміння, яких героїв вибирати на яку позицію і що купляти для них. На мою думку, дота 2 одна з найскладніших і найваріативніших ігор.

