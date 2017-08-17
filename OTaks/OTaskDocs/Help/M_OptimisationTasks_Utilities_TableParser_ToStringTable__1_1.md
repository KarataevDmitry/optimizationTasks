# TableParser.ToStringTable(*T*)(IEnumerable(*T*), String[], Func(*T*, Object)[]) - метод
 

\[<summary> отсутствует в документации для "M:OptimisationTasks.Utilities.TableParser.ToStringTable``1(System.Collections.Generic.IEnumerable{``0},System.String[],System.Func{``0,System.Object}[])"\]

**Пространство имён:**&nbsp;<a href="N_OptimisationTasks_Utilities">OptimisationTasks.Utilities</a><br />**Сборка:**&nbsp;OptimisationTasksEditor (в OptimisationTasksEditor.exe) Версия: 1.0.0.0 (1.0.0.0)

## Синтаксис

**C#**<br />
``` C#
public static string ToStringTable<T>(
	this IEnumerable<T> values,
	string[] columnHeaders,
	params Func<T, Object>[] valueSelectors
)

```

**F#**<br />
``` F#
[<ExtensionAttribute>]
static member ToStringTable : 
        values : IEnumerable<'T> * 
        columnHeaders : string[] * 
        valueSelectors : Func<'T, Object>[] -> string 

```


#### Параметры
&nbsp;<dl><dt>values</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/9eekhta0" target="_blank">System.Collections.Generic.IEnumerable</a>(*T*)<br />\[<param name="values"/> отсутствует в документации для "M:OptimisationTasks.Utilities.TableParser.ToStringTable``1(System.Collections.Generic.IEnumerable{``0},System.String[],System.Func{``0,System.Object}[])"\]</dd><dt>columnHeaders</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/s1wwdcbf" target="_blank">System.String</a>[]<br />\[<param name="columnHeaders"/> отсутствует в документации для "M:OptimisationTasks.Utilities.TableParser.ToStringTable``1(System.Collections.Generic.IEnumerable{``0},System.String[],System.Func{``0,System.Object}[])"\]</dd><dt>valueSelectors</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/bb549151" target="_blank">System.Func</a>(*T*, <a href="http://msdn2.microsoft.com/ru-ru/library/e5kfa45b" target="_blank">Object</a>)[]<br />\[<param name="valueSelectors"/> отсутствует в документации для "M:OptimisationTasks.Utilities.TableParser.ToStringTable``1(System.Collections.Generic.IEnumerable{``0},System.String[],System.Func{``0,System.Object}[])"\]</dd></dl>

#### Параметры типа
&nbsp;<dl><dt>T</dt><dd>\[<typeparam name="T"/> отсутствует в документации для "M:OptimisationTasks.Utilities.TableParser.ToStringTable``1(System.Collections.Generic.IEnumerable{``0},System.String[],System.Func{``0,System.Object}[])"\]</dd></dl>

#### Возвращаемое значение
Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/s1wwdcbf" target="_blank">String</a><br />\[<returns> отсутствует в документации для "M:OptimisationTasks.Utilities.TableParser.ToStringTable``1(System.Collections.Generic.IEnumerable{``0},System.String[],System.Func{``0,System.Object}[])"\]

#### Примечание об использовании
В Visual Basic и C# этот метод можно вызывать как метод экземпляра для любого объекта типа <a href="http://msdn2.microsoft.com/ru-ru/library/9eekhta0" target="_blank">IEnumerable</a>(*T*). При вызове метода для экземпляра следует опускать первый параметр. Дополнительные сведения см. в разделе <a href="http://msdn.microsoft.com/ru-ru/library/bb384936.aspx" target="_blank">Методы расширения (Visual Basic)</a> или <a href="http://msdn.microsoft.com/ru-ru/library/bb383977.aspx" target="_blank">Методы расширения (Руководство по программированию в C#)</a>.

## См. также


#### Ссылки
<a href="T_OptimisationTasks_Utilities_TableParser">TableParser - Класс</a><br /><a href="Overload_OptimisationTasks_Utilities_TableParser_ToStringTable">ToStringTable - перегрузка</a><br /><a href="N_OptimisationTasks_Utilities">OptimisationTasks.Utilities - пространство имён</a><br />