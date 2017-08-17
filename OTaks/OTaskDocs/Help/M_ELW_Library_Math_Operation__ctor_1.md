# Operation(String, OperationKind, String[], Int32, IOperationCalculator, Int32) - конструктор
 

Инициализирует новый экземпляр класса <a href="T_ELW_Library_Math_Operation">Operation</a>

**Пространство имён:**&nbsp;<a href="N_ELW_Library_Math">ELW.Library.Math</a><br />**Сборка:**&nbsp;ELW.Library.Math (в ELW.Library.Math.dll) Версия: 0.1.0.2

## Синтаксис

**C#**<br />
``` C#
public Operation(
	string name,
	OperationKind kind,
	string[] signature,
	int operandsCount,
	IOperationCalculator calculator,
	int priority
)
```

**F#**<br />
``` F#
new : 
        name : string * 
        kind : OperationKind * 
        signature : string[] * 
        operandsCount : int * 
        calculator : IOperationCalculator * 
        priority : int -> Operation
```


#### Параметры
&nbsp;<dl><dt>name</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/s1wwdcbf" target="_blank">System.String</a><br />\[<param name="name"/> отсутствует в документации для "M:ELW.Library.Math.Operation.#ctor(System.String,ELW.Library.Math.OperationKind,System.String[],System.Int32,ELW.Library.Math.Calculators.IOperationCalculator,System.Int32)"\]</dd><dt>kind</dt><dd>Тип:&nbsp;<a href="T_ELW_Library_Math_OperationKind">ELW.Library.Math.OperationKind</a><br />\[<param name="kind"/> отсутствует в документации для "M:ELW.Library.Math.Operation.#ctor(System.String,ELW.Library.Math.OperationKind,System.String[],System.Int32,ELW.Library.Math.Calculators.IOperationCalculator,System.Int32)"\]</dd><dt>signature</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/s1wwdcbf" target="_blank">System.String</a>[]<br />\[<param name="signature"/> отсутствует в документации для "M:ELW.Library.Math.Operation.#ctor(System.String,ELW.Library.Math.OperationKind,System.String[],System.Int32,ELW.Library.Math.Calculators.IOperationCalculator,System.Int32)"\]</dd><dt>operandsCount</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />\[<param name="operandsCount"/> отсутствует в документации для "M:ELW.Library.Math.Operation.#ctor(System.String,ELW.Library.Math.OperationKind,System.String[],System.Int32,ELW.Library.Math.Calculators.IOperationCalculator,System.Int32)"\]</dd><dt>calculator</dt><dd>Тип:&nbsp;<a href="T_ELW_Library_Math_Calculators_IOperationCalculator">ELW.Library.Math.Calculators.IOperationCalculator</a><br />\[<param name="calculator"/> отсутствует в документации для "M:ELW.Library.Math.Operation.#ctor(System.String,ELW.Library.Math.OperationKind,System.String[],System.Int32,ELW.Library.Math.Calculators.IOperationCalculator,System.Int32)"\]</dd><dt>priority</dt><dd>Тип:&nbsp;<a href="http://msdn2.microsoft.com/ru-ru/library/td2s409d" target="_blank">System.Int32</a><br />\[<param name="priority"/> отсутствует в документации для "M:ELW.Library.Math.Operation.#ctor(System.String,ELW.Library.Math.OperationKind,System.String[],System.Int32,ELW.Library.Math.Calculators.IOperationCalculator,System.Int32)"\]</dd></dl>

## См. также


#### Ссылки
<a href="T_ELW_Library_Math_Operation">Operation - Класс</a><br /><a href="Overload_ELW_Library_Math_Operation__ctor">Operation - перегрузка</a><br /><a href="N_ELW_Library_Math">ELW.Library.Math - пространство имён</a><br />