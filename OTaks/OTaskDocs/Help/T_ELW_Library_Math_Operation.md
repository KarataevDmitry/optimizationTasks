# Operation - класс
 

Represents an operation with calculator associated.


## Иерархия наследования
<a href="http://msdn2.microsoft.com/ru-ru/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;ELW.Library.Math.Operation<br />
**Пространство имён:**&nbsp;<a href="N_ELW_Library_Math">ELW.Library.Math</a><br />**Сборка:**&nbsp;ELW.Library.Math (в ELW.Library.Math.dll) Версия: 0.1.0.2

## Синтаксис

**C#**<br />
``` C#
public sealed class Operation
```

**F#**<br />
``` F#
[<SealedAttribute>]
type Operation =  class end
```

Тип Operation предоставляет следующие члены.


## Конструкторы
&nbsp;<table><tr><th></th><th>Имя</th><th>Описание</th></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ELW_Library_Math_Operation__ctor">Operation(String, OperationKind, String[], Int32, IOperationCalculator)</a></td><td>
Инициализирует новый экземпляр класса Operation</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ELW_Library_Math_Operation__ctor_1">Operation(String, OperationKind, String[], Int32, IOperationCalculator, Int32)</a></td><td>
Инициализирует новый экземпляр класса Operation</td></tr></table>&nbsp;
<a href="#operation---класс">В начало страницы</a>

## Свойства
&nbsp;<table><tr><th></th><th>Имя</th><th>Описание</th></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ELW_Library_Math_Operation_Calculator">Calculator</a></td><td>
Calculator for this operation.</td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ELW_Library_Math_Operation_Kind">Kind</a></td><td>
Kind of operation.</td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ELW_Library_Math_Operation_Name">Name</a></td><td>
Operation name - unique string.</td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ELW_Library_Math_Operation_OperandsCount">OperandsCount</a></td><td>
Count of operands.</td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ELW_Library_Math_Operation_Priority">Priority</a></td><td>
Integer priority of operation.</td></tr><tr><td>![Открытое свойство]( "Открытое свойство")</td><td><a href="P_ELW_Library_Math_Operation_Signature">Signature</a></td><td>
Set of signature strings.</td></tr></table>&nbsp;
<a href="#operation---класс">В начало страницы</a>

## Методы
&nbsp;<table><tr><th></th><th>Имя</th><th>Описание</th></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="http://msdn2.microsoft.com/ru-ru/library/bsc2ak47" target="_blank">Equals</a></td><td> (Унаследован от <a href="http://msdn2.microsoft.com/ru-ru/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="http://msdn2.microsoft.com/ru-ru/library/zdee4b3y" target="_blank">GetHashCode</a></td><td> (Унаследован от <a href="http://msdn2.microsoft.com/ru-ru/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="http://msdn2.microsoft.com/ru-ru/library/dfwy45w9" target="_blank">GetType</a></td><td> (Унаследован от <a href="http://msdn2.microsoft.com/ru-ru/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Открытый метод]( "Открытый метод")</td><td><a href="M_ELW_Library_Math_Operation_ToString">ToString</a></td><td> (Переопределяет <a href="http://msdn2.microsoft.com/ru-ru/library/7bxwbwt2" target="_blank">Object.ToString()</a>.)</td></tr></table>&nbsp;
<a href="#operation---класс">В начало страницы</a>

## См. также


#### Ссылки
<a href="N_ELW_Library_Math">ELW.Library.Math - пространство имён</a><br />