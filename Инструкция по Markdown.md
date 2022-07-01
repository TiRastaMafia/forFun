# Что такое Markdown
*Markdown* — язык текстовой разметки, созданный писателем и блогером Джоном Грубером. Он предназначен для создания красиво оформленных текстов в обычных файлах формата TXT. Вам не нужны громоздкие процессоры вроде Word или Pages, чтобы создавать документы с жирным или курсивным начертанием, цитатами, ссылками и даже таблицами. Достаточно запомнить простые правила Markdown, и можно писать хоть в «Блокноте». Хотя специализированные Markdown-редакторы, конечно, намного удобнее.

## Преимущества Markdown
Универсальность
Документы, написанные с использованием синтаксиса Markdown, представляют собой обычные текстовые файлы TXT. Их можно открыть на любой платформе и в любом редакторе. Этим они выгодно отличаются от файлов, созданных в текстовых процессорах. Пробовали открыть документ из Apple Pages в Word?

### Простота
Markdown настолько прост, что его за 10 минут смогут освоить даже те, кто до этого не слышал про все эти ваши Latex и HTML. Решётки для подзаголовков, звёздочки для выделения, тире для списков. Проще быть не может.

### Большой выбор инструментов
Редакторов для работы с документами Markdown очень, очень много. Есть и онлайновые, и мобильные, и настольные инструменты. Есть монструозный Atom, красивые и минималистичные ghostwriter и iA Writer, Vim для гиков и Ulysses для профессиональных писателей. Выбирай не хочу.

### Конвертируемость
Документы Markdown легко экспортировать в любые форматы: PDF, DOC, ODT. При этом их форматирование остаётся неизменным.

### Недостатки Markdown
Ограниченность форматирования
Так как документы Markdown представляют собой просто текстовые файлы, красивых шрифтов в них не применишь. Всё-таки это скорее инструмент для написания черновиков, чем для полноценной вёрстки.

### Строгие правила
В Markdown текст оформляется посредством служебных символов. Один лишний знак * или #, и форматирование изменится. Так что при наборе текстов в Markdown придётся быть внимательным.

### Базовый синтаксис
Тексты в Markdown оформляются посредством специальных символов, вставляемых перед или после слов и фраз. Вот самые простые правила, которые работают во всех редакторах.

# ЗАГОЛОВКИ

Делать заголовки в Markdown чрезвычайно просто. Всё, что вам нужно запомнить, — символ #, он же решётка, он же хеш. Уровень заголовка определяется количеством решёток в нём, всего их может быть шесть. Выглядит это так:

# Заголовок H1
## Заголовок H2
### Заголовок H3
#### Заголовок H4
##### Заголовок H5
###### Заголовок H6

Текст
Markdown: выделение текста


Помимо заголовков, Markdown поддерживает и простое форматирование текста. Его можно сделать курсивным или жирным при помощи звёздочек и подчёркиваний (писать без пробелов):

.*  Курсив * и _ Курсив _
** Жирный текст ** и __ Жирный текст __
*** Жирный и курсивный текст ***

*Курсив* и _Курсив_
**Жирный текст** и __Жирный текст__
***Жирный и курсивный текст***


Иногда какой-то абзац нужно выделить как цитату. В этом случае воспользуйтесь знаком >. Его необходимо проставлять перед каждой строчкой цитаты.

> Очень глубокомысленная цитата. Пожалуйста, прочтите её внимательно.
>
> Оскар Уайльд

Нумерованные и маркированные списки
Markdown: списки


Markdown позволяет создавать списки с любым уровнем вложенности. Маркированные списки делаются с помощью дефиса, проставляемого перед каждым пунктом:

- Первый пункт.
- Второй пункт.
- Третий пункт.

Нумерованные списки создаются точно так же, но с использованием цифр:

1. Первый пункт.
2. Второй пункт.
3. Третий пункт.

Можно составлять и смешанные списки с неограниченной вложенностью. Для этого нужно нажать Tab один раз или дважды на пробел.

1. Первый пункт.
- Первый подпункт.
- Второй подпункт.
- Третий подпункт.
2. Второй пункт.
- Первый подпункт.
- Второй подпункт.
- Третий подпункт.

Горизонтальные линии
Markdown: горизонтальные линии


Просто введите три раза (или больше) один из этих символов на клавиатуре: *, — или _, и в документ вставится горизонтальная линия. Если строкой выше над ней стоит ещё какой-то текст, он станет заголовком первого уровня. Линию можно использовать, чтобы разделять большие главы документа.

***
---
___

Ссылки и изображения
Markdown: ссылки и изображения

В ваши документы можно вставлять и ссылки на страницы в интернете. Делается это вот так: [заголовок_ссылки](сама_ссылка):

[Лайфхакер](lifehacker.ru)

Аналогично в документ вставляются и изображения. Поставьте восклицательный знак, подпись к изображению в квадратных скобках и ссылку на него в круглых скобках. Можно указывать ссылки на картинки как из интернета, так и на хранящиеся на жёстком диске. Подпись указывать необязательно. Выглядит это следующим образом:

![Медведь](data:image/jpeg;base64,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)

Эскапированные символы
Иногда вам нужно вставить в документ какой-нибудь символ, который относится к синтаксису Markdown. Вы печатаете его, и форматирование меняется, хоть вам это и не нужно. В таком случае перед техническими символами нужно ставить обратный слэш — \.

Расширенный синтаксис
Чуть более сложные элементы оформления текстов, которые можно использовать в редакторах, поддерживающих GFM (GitHub Flavored Markdown). GFM — расширенная версия обычного Markdown. Тут есть таблицы, смайлы, зачёркнутый текст и прочие мелочи. GFM используется в большинстве редакторов.

Зачёркнутый текст
Markdown: зачёркнутый текст

Расширенный синтаксис Markdown GFM позволяет зачёркивать текст, заключая его в двойные тильды ~~.

~~Зачёркнутый текст.~~

Таблицы
Markdown: таблицы

Если ваш редактор поддерживает GFM, то в нём можно создавать простенькие таблицы. Для таблиц используйте символы | и -. Примерно так:

| раз | два | три |
|:----|:----|:----|
| раз | два | три |

Списки дел
Markdown: списки дел

В Markdown есть даже своеобразные списки задач — аналог чекбоксов в OneNote или Evernote. Вот как они выглядят:

- [ ] Невыполненная задача
- [ ] Невыполненная задача
- [X] Выполненная задача

Код
Markdown: код

Поскольку GFM создавался для программистов, в нём есть специальное форматирование для кусков кода. Код выделяется символом `, то есть грависом. Окружив слово или фразу грависами, можно создавать строчки кода:

`Какой-то очень важный код.`

А три грависа позволяют отметить целый блок кода. Ещё это полезно, чтобы выделить целый абзац.

```
Целый абзац очень важного кода.
И ещё строка.
И ещё.
```