# TableParser.ToStringTable(*T*)(*T*[], String[], Func(*T*, Object)[]) - метод
 

**Пространство имён:**&nbsp;<a href="N_OptimisationTasks_Utilities">OptimisationTasks.Utilities</a><br />**Сборка:**&nbsp;OptimisationTasksEditor (в OptimisationTasksEditor.exe) Версия: 1.0.0.0 (1.0.0.0)

## Синтаксис

**C#**<br />
``` C#
public static string ToStringTable<T>(
	this T[] values,
	string[] columnHeaders,
	params Func<T, Object>[] valueSelectors
)

```

**F#**<br />
``` F#
[<ExtensionAttribute>]
static member ToStringTable : 
        values : 'T[] * 
        columnHeaders : string[] * 
        valueSelectors : Func<'T, Object>[] -> string 

```


#### Параметры
&nbsp;<dl><dt>values</dt><dd>Тип:&nbsp;*T*[]<br /></dd><dt>columnHeaders</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/s1wwdcbf" target="_blank">System.String</a>[]<br /></dd><dt>valueSelectors</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/bb549151" target="_blank">System.Func</a>(*T*, <a href="http://msdn2.microsoft.com/ru-ru/library/e5kfa45b" target="_blank">Object</a>)[]<br /></dd></dl>

#### Параметры типа
&nbsp;<dl><dt>T</dt><dd /></dl>

#### Возвращаемое значение
Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/s1wwdcbf" target="_blank">String</a>

#### Примечание об использовании
В Visual Basic и C# этот метод можно вызывать как метод экземпляра для любого объекта типа . При вызове метода для экземпляра следует опускать первый параметр. Дополнительные сведения см. в разделе <a href="http://msdn.microsoft.com/ru-ru/library/bb384936.aspx" target="_blank">Методы расширения (Visual Basic)</a> или <a href="http://msdn.microsoft.com/ru-ru/library/bb383977.aspx" target="_blank">Методы расширения (Руководство по программированию в C#)</a>.

## См. также


#### Ссылки
<a href="T_OptimisationTasks_Utilities_TableParser">TableParser - Класс</a><br /><a href="Overload_OptimisationTasks_Utilities_TableParser_ToStringTable">ToStringTable - перегрузка</a><br /><a href="N_OptimisationTasks_Utilities">OptimisationTasks.Utilities - пространство имён</a><br />