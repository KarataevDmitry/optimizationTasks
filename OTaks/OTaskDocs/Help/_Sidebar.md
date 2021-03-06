- [OptimisationTasks](57ad410e-78fe-4d23-9668-a5607f1bd1f3)
- [Version History](f85f2bd1-290d-43ef-becf-827ffce9fb60)
  - [Version 1.0.0.0](ae3dad57-d2f1-45b6-90a8-a2e199795f52)
- [ELW.Library - пространства имён](G_ELW_Library)
  - [ELW.Library.Math - пространство имён](N_ELW_Library_Math)
    - [Operation - класс](T_ELW_Library_Math_Operation)
      - [Operation - конструктор](Overload_ELW_Library_Math_Operation__ctor)
        - [Operation(String, OperationKind, String[], Int32, IOperationCalculator) - конструктор](M_ELW_Library_Math_Operation__ctor)
        - [Operation(String, OperationKind, String[], Int32, IOperationCalculator, Int32) - конструктор](M_ELW_Library_Math_Operation__ctor_1)
      - [Operation - свойства](Properties_T_ELW_Library_Math_Operation)
        - [Operation.Calculator - свойство](P_ELW_Library_Math_Operation_Calculator)
        - [Operation.Kind - свойство](P_ELW_Library_Math_Operation_Kind)
        - [Operation.Name - свойство](P_ELW_Library_Math_Operation_Name)
        - [Operation.OperandsCount - свойство](P_ELW_Library_Math_Operation_OperandsCount)
        - [Operation.Priority - свойство](P_ELW_Library_Math_Operation_Priority)
        - [Operation.Signature - свойство](P_ELW_Library_Math_Operation_Signature)
      - [Operation - методы](Methods_T_ELW_Library_Math_Operation)
        - [Operation.ToString - метод](M_ELW_Library_Math_Operation_ToString)
    - [OperationKind - перечисление](T_ELW_Library_Math_OperationKind)
    - [OperationsRegistry - класс](T_ELW_Library_Math_OperationsRegistry)
      - [OperationsRegistry - конструктор](M_ELW_Library_Math_OperationsRegistry__ctor)
      - [OperationsRegistry - свойства](Properties_T_ELW_Library_Math_OperationsRegistry)
        - [OperationsRegistry.SignaturesLens - свойство](P_ELW_Library_Math_OperationsRegistry_SignaturesLens)
      - [OperationsRegistry - методы](Methods_T_ELW_Library_Math_OperationsRegistry)
        - [OperationsRegistry.GetAssociationByPriority - метод](M_ELW_Library_Math_OperationsRegistry_GetAssociationByPriority)
        - [OperationsRegistry.GetOperationByName - метод](M_ELW_Library_Math_OperationsRegistry_GetOperationByName)
        - [OperationsRegistry.GetOperationsUsingSignature - метод](M_ELW_Library_Math_OperationsRegistry_GetOperationsUsingSignature)
        - [OperationsRegistry.IsOperationDefined - метод](M_ELW_Library_Math_OperationsRegistry_IsOperationDefined)
        - [OperationsRegistry.IsPriorityDefined - метод](M_ELW_Library_Math_OperationsRegistry_IsPriorityDefined)
        - [OperationsRegistry.IsSignatureDefined - метод](M_ELW_Library_Math_OperationsRegistry_IsSignatureDefined)
    - [PriorityAssociation - перечисление](T_ELW_Library_Math_PriorityAssociation)
    - [ToolsHelper - класс](T_ELW_Library_Math_ToolsHelper)
      - [ToolsHelper - свойства](Properties_T_ELW_Library_Math_ToolsHelper)
        - [ToolsHelper.Calculator - свойство](P_ELW_Library_Math_ToolsHelper_Calculator)
        - [ToolsHelper.Compiler - свойство](P_ELW_Library_Math_ToolsHelper_Compiler)
        - [ToolsHelper.Decompiler - свойство](P_ELW_Library_Math_ToolsHelper_Decompiler)
        - [ToolsHelper.OperationsRegistry - свойство](P_ELW_Library_Math_ToolsHelper_OperationsRegistry)
        - [ToolsHelper.Optimizer - свойство](P_ELW_Library_Math_ToolsHelper_Optimizer)
        - [ToolsHelper.Parser - свойство](P_ELW_Library_Math_ToolsHelper_Parser)
  - [ELW.Library.Math.Calculators - пространство имён](N_ELW_Library_Math_Calculators)
    - [IOperationCalculator - интерфейс](T_ELW_Library_Math_Calculators_IOperationCalculator)
      - [IOperationCalculator - методы](Methods_T_ELW_Library_Math_Calculators_IOperationCalculator)
        - [IOperationCalculator.Calculate - метод](M_ELW_Library_Math_Calculators_IOperationCalculator_Calculate)
  - [ELW.Library.Math.Exceptions - пространство имён](N_ELW_Library_Math_Exceptions)
    - [CompilerSyntaxException - класс](T_ELW_Library_Math_Exceptions_CompilerSyntaxException)
      - [CompilerSyntaxException - конструктор](Overload_ELW_Library_Math_Exceptions_CompilerSyntaxException__ctor)
        - [CompilerSyntaxException - конструктор](M_ELW_Library_Math_Exceptions_CompilerSyntaxException__ctor)
        - [CompilerSyntaxException(String) - конструктор](M_ELW_Library_Math_Exceptions_CompilerSyntaxException__ctor_2)
        - [CompilerSyntaxException(SerializationInfo, StreamingContext) - конструктор](M_ELW_Library_Math_Exceptions_CompilerSyntaxException__ctor_1)
        - [CompilerSyntaxException(String, Exception) - конструктор](M_ELW_Library_Math_Exceptions_CompilerSyntaxException__ctor_3)
      - [CompilerSyntaxException - свойства](Properties_T_ELW_Library_Math_Exceptions_CompilerSyntaxException)
      - [CompilerSyntaxException - методы](Methods_T_ELW_Library_Math_Exceptions_CompilerSyntaxException)
      - [CompilerSyntaxException - события](Events_T_ELW_Library_Math_Exceptions_CompilerSyntaxException)
    - [MathProcessorException - класс](T_ELW_Library_Math_Exceptions_MathProcessorException)
      - [MathProcessorException - конструктор](Overload_ELW_Library_Math_Exceptions_MathProcessorException__ctor)
        - [MathProcessorException - конструктор](M_ELW_Library_Math_Exceptions_MathProcessorException__ctor)
        - [MathProcessorException(String) - конструктор](M_ELW_Library_Math_Exceptions_MathProcessorException__ctor_2)
        - [MathProcessorException(SerializationInfo, StreamingContext) - конструктор](M_ELW_Library_Math_Exceptions_MathProcessorException__ctor_1)
        - [MathProcessorException(String, Exception) - конструктор](M_ELW_Library_Math_Exceptions_MathProcessorException__ctor_3)
      - [MathProcessorException - свойства](Properties_T_ELW_Library_Math_Exceptions_MathProcessorException)
      - [MathProcessorException - методы](Methods_T_ELW_Library_Math_Exceptions_MathProcessorException)
      - [MathProcessorException - события](Events_T_ELW_Library_Math_Exceptions_MathProcessorException)
  - [ELW.Library.Math.Expressions - пространство имён](N_ELW_Library_Math_Expressions)
    - [CompiledExpression - класс](T_ELW_Library_Math_Expressions_CompiledExpression)
      - [CompiledExpression - конструктор](M_ELW_Library_Math_Expressions_CompiledExpression__ctor)
      - [CompiledExpression - свойства](Properties_T_ELW_Library_Math_Expressions_CompiledExpression)
        - [CompiledExpression.CompiledExpressionItems - свойство](P_ELW_Library_Math_Expressions_CompiledExpression_CompiledExpressionItems)
      - [CompiledExpression - методы](Methods_T_ELW_Library_Math_Expressions_CompiledExpression)
    - [CompiledExpressionItem - класс](T_ELW_Library_Math_Expressions_CompiledExpressionItem)
      - [CompiledExpressionItem - конструктор](M_ELW_Library_Math_Expressions_CompiledExpressionItem__ctor)
      - [CompiledExpressionItem - свойства](Properties_T_ELW_Library_Math_Expressions_CompiledExpressionItem)
        - [CompiledExpressionItem.Constant - свойство](P_ELW_Library_Math_Expressions_CompiledExpressionItem_Constant)
        - [CompiledExpressionItem.Kind - свойство](P_ELW_Library_Math_Expressions_CompiledExpressionItem_Kind)
        - [CompiledExpressionItem.OperationName - свойство](P_ELW_Library_Math_Expressions_CompiledExpressionItem_OperationName)
        - [CompiledExpressionItem.VariableName - свойство](P_ELW_Library_Math_Expressions_CompiledExpressionItem_VariableName)
      - [CompiledExpressionItem - методы](Methods_T_ELW_Library_Math_Expressions_CompiledExpressionItem)
        - [CompiledExpressionItem.ToString - метод](M_ELW_Library_Math_Expressions_CompiledExpressionItem_ToString)
    - [CompiledExpressionItemKind - перечисление](T_ELW_Library_Math_Expressions_CompiledExpressionItemKind)
    - [DelimiterKind - перечисление](T_ELW_Library_Math_Expressions_DelimiterKind)
    - [PreparedExpression - класс](T_ELW_Library_Math_Expressions_PreparedExpression)
      - [PreparedExpression - конструктор](M_ELW_Library_Math_Expressions_PreparedExpression__ctor)
      - [PreparedExpression - свойства](Properties_T_ELW_Library_Math_Expressions_PreparedExpression)
        - [PreparedExpression.PreparedExpressionItems - свойство](P_ELW_Library_Math_Expressions_PreparedExpression_PreparedExpressionItems)
      - [PreparedExpression - методы](Methods_T_ELW_Library_Math_Expressions_PreparedExpression)
        - [PreparedExpression.ToString - метод](M_ELW_Library_Math_Expressions_PreparedExpression_ToString)
      - [PreparedExpression - поля](Fields_T_ELW_Library_Math_Expressions_PreparedExpression)
        - [PreparedExpression.preparedExpressionItems - поле](F_ELW_Library_Math_Expressions_PreparedExpression_preparedExpressionItems)
    - [PreparedExpressionItem - класс](T_ELW_Library_Math_Expressions_PreparedExpressionItem)
      - [PreparedExpressionItem - конструктор](M_ELW_Library_Math_Expressions_PreparedExpressionItem__ctor)
      - [PreparedExpressionItem - свойства](Properties_T_ELW_Library_Math_Expressions_PreparedExpressionItem)
        - [PreparedExpressionItem.Constant - свойство](P_ELW_Library_Math_Expressions_PreparedExpressionItem_Constant)
        - [PreparedExpressionItem.DelimiterKind - свойство](P_ELW_Library_Math_Expressions_PreparedExpressionItem_DelimiterKind)
        - [PreparedExpressionItem.Kind - свойство](P_ELW_Library_Math_Expressions_PreparedExpressionItem_Kind)
        - [PreparedExpressionItem.Signature - свойство](P_ELW_Library_Math_Expressions_PreparedExpressionItem_Signature)
        - [PreparedExpressionItem.VariableName - свойство](P_ELW_Library_Math_Expressions_PreparedExpressionItem_VariableName)
      - [PreparedExpressionItem - методы](Methods_T_ELW_Library_Math_Expressions_PreparedExpressionItem)
        - [PreparedExpressionItem.ToString - метод](M_ELW_Library_Math_Expressions_PreparedExpressionItem_ToString)
    - [PreparedExpressionItemKind - перечисление](T_ELW_Library_Math_Expressions_PreparedExpressionItemKind)
  - [ELW.Library.Math.Tools - пространство имён](N_ELW_Library_Math_Tools)
    - [Calculator - класс](T_ELW_Library_Math_Tools_Calculator)
      - [Calculator - конструктор](M_ELW_Library_Math_Tools_Calculator__ctor)
      - [Calculator - свойства](Properties_T_ELW_Library_Math_Tools_Calculator)
        - [Calculator.OperationsRegistry - свойство](P_ELW_Library_Math_Tools_Calculator_OperationsRegistry)
      - [Calculator - методы](Methods_T_ELW_Library_Math_Tools_Calculator)
        - [Calculator.Calculate - метод](M_ELW_Library_Math_Tools_Calculator_Calculate)
    - [Compiler - класс](T_ELW_Library_Math_Tools_Compiler)
      - [Compiler - конструктор](M_ELW_Library_Math_Tools_Compiler__ctor)
      - [Compiler - свойства](Properties_T_ELW_Library_Math_Tools_Compiler)
        - [Compiler.OperationsRegistry - свойство](P_ELW_Library_Math_Tools_Compiler_OperationsRegistry)
      - [Compiler - методы](Methods_T_ELW_Library_Math_Tools_Compiler)
        - [Compiler.Compile - метод](M_ELW_Library_Math_Tools_Compiler_Compile)
    - [Decompiler - класс](T_ELW_Library_Math_Tools_Decompiler)
      - [Decompiler - конструктор](M_ELW_Library_Math_Tools_Decompiler__ctor)
      - [Decompiler - свойства](Properties_T_ELW_Library_Math_Tools_Decompiler)
        - [Decompiler.OperationsRegistry - свойство](P_ELW_Library_Math_Tools_Decompiler_OperationsRegistry)
      - [Decompiler - методы](Methods_T_ELW_Library_Math_Tools_Decompiler)
        - [Decompiler.Decompile - метод](M_ELW_Library_Math_Tools_Decompiler_Decompile)
    - [Optimizer - класс](T_ELW_Library_Math_Tools_Optimizer)
      - [Optimizer - конструктор](M_ELW_Library_Math_Tools_Optimizer__ctor)
      - [Optimizer - свойства](Properties_T_ELW_Library_Math_Tools_Optimizer)
        - [Optimizer.OperationsRegistry - свойство](P_ELW_Library_Math_Tools_Optimizer_OperationsRegistry)
      - [Optimizer - методы](Methods_T_ELW_Library_Math_Tools_Optimizer)
        - [Optimizer.Optimize - метод](M_ELW_Library_Math_Tools_Optimizer_Optimize)
    - [Parser - класс](T_ELW_Library_Math_Tools_Parser)
      - [Parser - конструктор](M_ELW_Library_Math_Tools_Parser__ctor)
      - [Parser - свойства](Properties_T_ELW_Library_Math_Tools_Parser)
        - [Parser.OperationsRegistry - свойство](P_ELW_Library_Math_Tools_Parser_OperationsRegistry)
      - [Parser - методы](Methods_T_ELW_Library_Math_Tools_Parser)
        - [Parser.IsValidVariableName - метод](M_ELW_Library_Math_Tools_Parser_IsValidVariableName)
        - [Parser.Parse - метод](M_ELW_Library_Math_Tools_Parser_Parse)
    - [VariableValue - класс](T_ELW_Library_Math_Tools_VariableValue)
      - [VariableValue - конструктор](M_ELW_Library_Math_Tools_VariableValue__ctor)
      - [VariableValue - свойства](Properties_T_ELW_Library_Math_Tools_VariableValue)
        - [VariableValue.Value - свойство](P_ELW_Library_Math_Tools_VariableValue_Value)
        - [VariableValue.VariableName - свойство](P_ELW_Library_Math_Tools_VariableValue_VariableName)
      - [VariableValue - методы](Methods_T_ELW_Library_Math_Tools_VariableValue)
- [OptimisationTasks - пространства имён](G_OptimisationTasks)
  - [OptimisationTasks.DataStructures - пространства имён](G_OptimisationTasks_DataStructures)
    - [OptimisationTasks.DataStructures - пространство имён](N_OptimisationTasks_DataStructures)
      - [Interval - структура](T_OptimisationTasks_DataStructures_Interval)
        - [Interval - конструктор](Overload_OptimisationTasks_DataStructures_Interval__ctor)
          - [Interval(String) - конструктор](M_OptimisationTasks_DataStructures_Interval__ctor_1)
          - [Interval(Double, Double) - конструктор](M_OptimisationTasks_DataStructures_Interval__ctor)
        - [Interval - свойства](Properties_T_OptimisationTasks_DataStructures_Interval)
          - [Interval.Length - свойство](P_OptimisationTasks_DataStructures_Interval_Length)
        - [Interval - методы](Methods_T_OptimisationTasks_DataStructures_Interval)
          - [Interval.ToString - метод](M_OptimisationTasks_DataStructures_Interval_ToString)
        - [Interval - поля](Fields_T_OptimisationTasks_DataStructures_Interval)
          - [Interval.Left - поле](F_OptimisationTasks_DataStructures_Interval_Left)
          - [Interval.Right - поле](F_OptimisationTasks_DataStructures_Interval_Right)
      - [OptKind - перечисление](T_OptimisationTasks_DataStructures_OptKind)
      - [Task1D - класс](T_OptimisationTasks_DataStructures_Task1D)
        - [Task1D - конструктор](M_OptimisationTasks_DataStructures_Task1D__ctor)
        - [Task1D - свойства](Properties_T_OptimisationTasks_DataStructures_Task1D)
          - [Task1D.OptimumInterval - свойство](P_OptimisationTasks_DataStructures_Task1D_OptimumInterval)
          - [Task1D.OptimumType - свойство](P_OptimisationTasks_DataStructures_Task1D_OptimumType)
          - [Task1D.TargetFunction - свойство](P_OptimisationTasks_DataStructures_Task1D_TargetFunction)
          - [Task1D.VariableName - свойство](P_OptimisationTasks_DataStructures_Task1D_VariableName)
        - [Task1D - методы](Methods_T_OptimisationTasks_DataStructures_Task1D)
          - [Task1D.GetFuncResult - метод](M_OptimisationTasks_DataStructures_Task1D_GetFuncResult)
    - [OptimisationTasks.DataStructures.LinearProgramming - пространство имён](N_OptimisationTasks_DataStructures_LinearProgramming)
      - [LinearTask - класс](T_OptimisationTasks_DataStructures_LinearProgramming_LinearTask)
        - [LinearTask - конструктор](Overload_OptimisationTasks_DataStructures_LinearProgramming_LinearTask__ctor)
          - [LinearTask(Double[,]) - конструктор](M_OptimisationTasks_DataStructures_LinearProgramming_LinearTask__ctor_1)
          - [LinearTask(Matrix) - конструктор](M_OptimisationTasks_DataStructures_LinearProgramming_LinearTask__ctor)
        - [LinearTask - методы](Methods_T_OptimisationTasks_DataStructures_LinearProgramming_LinearTask)
          - [LinearTask.Optimize - метод](M_OptimisationTasks_DataStructures_LinearProgramming_LinearTask_Optimize)
      - [Matrix - класс](T_OptimisationTasks_DataStructures_LinearProgramming_Matrix)
        - [Matrix - конструктор](Overload_OptimisationTasks_DataStructures_LinearProgramming_Matrix__ctor)
          - [Matrix(Double[,]) - конструктор](M_OptimisationTasks_DataStructures_LinearProgramming_Matrix__ctor)
          - [Matrix(Int32, Int32) - конструктор](M_OptimisationTasks_DataStructures_LinearProgramming_Matrix__ctor_1)
        - [Matrix - свойства](Properties_T_OptimisationTasks_DataStructures_LinearProgramming_Matrix)
          - [Matrix.ColCount - свойство](P_OptimisationTasks_DataStructures_LinearProgramming_Matrix_ColCount)
          - [Matrix.Count - свойство](P_OptimisationTasks_DataStructures_LinearProgramming_Matrix_Count)
          - [Matrix.IsFixedSize - свойство](P_OptimisationTasks_DataStructures_LinearProgramming_Matrix_IsFixedSize)
          - [Matrix.IsReadOnly - свойство](P_OptimisationTasks_DataStructures_LinearProgramming_Matrix_IsReadOnly)
          - [Matrix.Item - свойство](P_OptimisationTasks_DataStructures_LinearProgramming_Matrix_Item)
          - [Matrix.RowCount - свойство](P_OptimisationTasks_DataStructures_LinearProgramming_Matrix_RowCount)
        - [Matrix - методы](Methods_T_OptimisationTasks_DataStructures_LinearProgramming_Matrix)
          - [Matrix.IEnumerable.GetEnumerator - метод](M_OptimisationTasks_DataStructures_LinearProgramming_Matrix_System_Collections_IEnumerable_GetEnumerator)
          - [Matrix.RaiseMatrixChanged - метод](M_OptimisationTasks_DataStructures_LinearProgramming_Matrix_RaiseMatrixChanged)
          - [Matrix.ReadFromDataGrid - метод](M_OptimisationTasks_DataStructures_LinearProgramming_Matrix_ReadFromDataGrid)
          - [Matrix.ToArray - метод](M_OptimisationTasks_DataStructures_LinearProgramming_Matrix_ToArray)
          - [Matrix.WriteToDataGrid - метод](M_OptimisationTasks_DataStructures_LinearProgramming_Matrix_WriteToDataGrid)
        - [Matrix - события](Events_T_OptimisationTasks_DataStructures_LinearProgramming_Matrix)
          - [Matrix.MatrixChanged - событие](E_OptimisationTasks_DataStructures_LinearProgramming_Matrix_MatrixChanged)
  - [OptimisationTasks.FileOperations - пространство имён](N_OptimisationTasks_FileOperations)
    - [TaskReader - класс](T_OptimisationTasks_FileOperations_TaskReader)
      - [TaskReader - методы](Methods_T_OptimisationTasks_FileOperations_TaskReader)
        - [TaskReader.ReadTaskFromFile - метод](M_OptimisationTasks_FileOperations_TaskReader_ReadTaskFromFile)
    - [TaskWriter - класс](T_OptimisationTasks_FileOperations_TaskWriter)
      - [TaskWriter - методы](Methods_T_OptimisationTasks_FileOperations_TaskWriter)
        - [TaskWriter.WriteTaskToFile - метод](M_OptimisationTasks_FileOperations_TaskWriter_WriteTaskToFile)
  - [OptimisationTasks.Optimisation - пространства имён](G_OptimisationTasks_Optimisation)
    - [OptimisationTasks.Optimisation.Linear - пространство имён](N_OptimisationTasks_Optimisation_Linear)
      - [SimplexOptimizer - класс](T_OptimisationTasks_Optimisation_Linear_SimplexOptimizer)
        - [SimplexOptimizer - конструктор](M_OptimisationTasks_Optimisation_Linear_SimplexOptimizer__ctor)
        - [SimplexOptimizer - методы](Methods_T_OptimisationTasks_Optimisation_Linear_SimplexOptimizer)
          - [SimplexOptimizer.CalcSolution - метод](M_OptimisationTasks_Optimisation_Linear_SimplexOptimizer_CalcSolution)
  - [OptimisationTasks.OptimisationMethods - пространства имён](G_OptimisationTasks_OptimisationMethods)
    - [OptimisationTasks.OptimisationMethods - пространство имён](N_OptimisationTasks_OptimisationMethods)
      - [GoldenPropOptimisator - класс](T_OptimisationTasks_OptimisationMethods_GoldenPropOptimisator)
        - [GoldenPropOptimisator - конструктор](M_OptimisationTasks_OptimisationMethods_GoldenPropOptimisator__ctor)
        - [GoldenPropOptimisator - методы](Methods_T_OptimisationTasks_OptimisationMethods_GoldenPropOptimisator)
          - [GoldenPropOptimisator.Optimise - метод](Overload_OptimisationTasks_OptimisationMethods_GoldenPropOptimisator_Optimise)
            - [GoldenPropOptimisator.Optimise(Task1D, Double) - метод](M_OptimisationTasks_OptimisationMethods_GoldenPropOptimisator_Optimise)
      - [OptimizationMethod - класс](T_OptimisationTasks_OptimisationMethods_OptimizationMethod)
        - [OptimizationMethod - конструктор](M_OptimisationTasks_OptimisationMethods_OptimizationMethod__ctor)
        - [OptimizationMethod - методы](Methods_T_OptimisationTasks_OptimisationMethods_OptimizationMethod)
          - [OptimizationMethod.Optimise - метод](Overload_OptimisationTasks_OptimisationMethods_OptimizationMethod_Optimise)
            - [OptimizationMethod.Optimise(String, Double) - метод](M_OptimisationTasks_OptimisationMethods_OptimizationMethod_Optimise_2)
            - [OptimizationMethod.Optimise(Task1D, Double) - метод](M_OptimisationTasks_OptimisationMethods_OptimizationMethod_Optimise)
            - [OptimizationMethod.Optimise(String, OptKind, Double) - метод](M_OptimisationTasks_OptimisationMethods_OptimizationMethod_Optimise_1)
    - [OptimisationTasks.OptimisationMethods.Linear - пространство имён](N_OptimisationTasks_OptimisationMethods_Linear)
      - [ILinearOptimizer - интерфейс](T_OptimisationTasks_OptimisationMethods_Linear_ILinearOptimizer)
        - [ILinearOptimizer - методы](Methods_T_OptimisationTasks_OptimisationMethods_Linear_ILinearOptimizer)
          - [ILinearOptimizer.CalcSolution - метод](M_OptimisationTasks_OptimisationMethods_Linear_ILinearOptimizer_CalcSolution)
      - [Simplex - класс](T_OptimisationTasks_OptimisationMethods_Linear_Simplex)
        - [Simplex - конструктор](M_OptimisationTasks_OptimisationMethods_Linear_Simplex__ctor)
        - [Simplex - методы](Methods_T_OptimisationTasks_OptimisationMethods_Linear_Simplex)
          - [Simplex.Calculate - метод](M_OptimisationTasks_OptimisationMethods_Linear_Simplex_Calculate)
  - [OptimisationTasks.Utilites - пространство имён](N_OptimisationTasks_Utilites)
    - [ExpressionValidator - класс](T_OptimisationTasks_Utilites_ExpressionValidator)
      - [ExpressionValidator - конструктор](M_OptimisationTasks_Utilites_ExpressionValidator__ctor)
      - [ExpressionValidator - свойства](Properties_T_OptimisationTasks_Utilites_ExpressionValidator)
        - [ExpressionValidator.VALIDATION_STATUS_OK - свойство](P_OptimisationTasks_Utilites_ExpressionValidator_VALIDATION_STATUS_OK)
      - [ExpressionValidator - методы](Methods_T_OptimisationTasks_Utilites_ExpressionValidator)
        - [ExpressionValidator.Validate - метод](M_OptimisationTasks_Utilites_ExpressionValidator_Validate)
    - [ValidationResult - структура](T_OptimisationTasks_Utilites_ValidationResult)
      - [ValidationResult - конструктор](M_OptimisationTasks_Utilites_ValidationResult__ctor)
      - [ValidationResult - свойства](Properties_T_OptimisationTasks_Utilites_ValidationResult)
        - [ValidationResult.ErrorIn - свойство](P_OptimisationTasks_Utilites_ValidationResult_ErrorIn)
        - [ValidationResult.IsValid - свойство](P_OptimisationTasks_Utilites_ValidationResult_IsValid)
      - [ValidationResult - методы](Methods_T_OptimisationTasks_Utilites_ValidationResult)
  - [OptimisationTasks.Utilities - пространство имён](N_OptimisationTasks_Utilities)
    - [TableParser - класс](T_OptimisationTasks_Utilities_TableParser)
      - [TableParser - методы](Methods_T_OptimisationTasks_Utilities_TableParser)
        - [TableParser.ToStringTable - метод](Overload_OptimisationTasks_Utilities_TableParser_ToStringTable)
          - [TableParser.ToStringTable(String[,]) - метод](M_OptimisationTasks_Utilities_TableParser_ToStringTable)
          - [TableParser.ToStringTable(*T*)(IEnumerable(*T*), Expression(Func(*T*, Object))[]) - метод](M_OptimisationTasks_Utilities_TableParser_ToStringTable__1)
          - [TableParser.ToStringTable(*T*)(IEnumerable(*T*), String[], Func(*T*, Object)[]) - метод](M_OptimisationTasks_Utilities_TableParser_ToStringTable__1_1)
          - [TableParser.ToStringTable(*T*)(*T*[], String[], Func(*T*, Object)[]) - метод](M_OptimisationTasks_Utilities_TableParser_ToStringTable__1_2)
- [OptimisationTasksEditor - пространство имён](N_OptimisationTasksEditor)
  - [App - класс](T_OptimisationTasksEditor_App)
    - [App - конструктор](M_OptimisationTasksEditor_App__ctor)
    - [App - свойства](Properties_T_OptimisationTasksEditor_App)
    - [App - методы](Methods_T_OptimisationTasksEditor_App)
      - [App.InitializeComponent - метод](M_OptimisationTasksEditor_App_InitializeComponent)
      - [App.Main - метод](M_OptimisationTasksEditor_App_Main)
    - [App - события](Events_T_OptimisationTasksEditor_App)
  - [HelloPage - класс](T_OptimisationTasksEditor_HelloPage)
    - [HelloPage - конструктор](M_OptimisationTasksEditor_HelloPage__ctor)
    - [HelloPage - свойства](Properties_T_OptimisationTasksEditor_HelloPage)
    - [HelloPage - методы](Methods_T_OptimisationTasksEditor_HelloPage)
      - [HelloPage.IComponentConnector.Connect - метод](M_OptimisationTasksEditor_HelloPage_System_Windows_Markup_IComponentConnector_Connect)
      - [HelloPage.InitializeComponent - метод](M_OptimisationTasksEditor_HelloPage_InitializeComponent)
    - [HelloPage - события](Events_T_OptimisationTasksEditor_HelloPage)
  - [LinearOptimizationTaskDefinition - класс](T_OptimisationTasksEditor_LinearOptimizationTaskDefinition)
    - [LinearOptimizationTaskDefinition - конструктор](M_OptimisationTasksEditor_LinearOptimizationTaskDefinition__ctor)
    - [LinearOptimizationTaskDefinition - свойства](Properties_T_OptimisationTasksEditor_LinearOptimizationTaskDefinition)
    - [LinearOptimizationTaskDefinition - методы](Methods_T_OptimisationTasksEditor_LinearOptimizationTaskDefinition)
      - [LinearOptimizationTaskDefinition.IComponentConnector.Connect - метод](M_OptimisationTasksEditor_LinearOptimizationTaskDefinition_System_Windows_Markup_IComponentConnector_Connect)
      - [LinearOptimizationTaskDefinition.InitializeComponent - метод](M_OptimisationTasksEditor_LinearOptimizationTaskDefinition_InitializeComponent)
    - [LinearOptimizationTaskDefinition - события](Events_T_OptimisationTasksEditor_LinearOptimizationTaskDefinition)
  - [OneDimesionalTaskDefinition - класс](T_OptimisationTasksEditor_OneDimesionalTaskDefinition)
    - [OneDimesionalTaskDefinition - конструктор](M_OptimisationTasksEditor_OneDimesionalTaskDefinition__ctor)
    - [OneDimesionalTaskDefinition - свойства](Properties_T_OptimisationTasksEditor_OneDimesionalTaskDefinition)
    - [OneDimesionalTaskDefinition - методы](Methods_T_OptimisationTasksEditor_OneDimesionalTaskDefinition)
      - [OneDimesionalTaskDefinition.IComponentConnector.Connect - метод](M_OptimisationTasksEditor_OneDimesionalTaskDefinition_System_Windows_Markup_IComponentConnector_Connect)
      - [OneDimesionalTaskDefinition.InitializeComponent - метод](M_OptimisationTasksEditor_OneDimesionalTaskDefinition_InitializeComponent)
    - [OneDimesionalTaskDefinition - события](Events_T_OptimisationTasksEditor_OneDimesionalTaskDefinition)
