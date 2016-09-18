using ELW.Library.Math.Tools;

namespace ELW.Library.Math {
    /// <summary>
    /// Quick access to tool wanted.
    /// </summary>
    public static class ToolsHelper {
        private static readonly OperationsRegistry operationsRegistry;
        public static OperationsRegistry OperationsRegistry => operationsRegistry;

        private static readonly Parser parser;
        public static Parser Parser => parser;

        private static readonly Compiler compiler;
        public static Compiler Compiler => compiler;

        private static readonly Calculator calculator;
        public static Calculator Calculator => calculator;

        private static readonly Optimizer optimizer;
        public static Optimizer Optimizer => optimizer;

        private static readonly Decompiler decompiler;
        public static Decompiler Decompiler => decompiler;

        static ToolsHelper() {
            operationsRegistry = new OperationsRegistry();
            //
            parser = new Parser(operationsRegistry);
            compiler = new Compiler(operationsRegistry);
            calculator = new Calculator(operationsRegistry);
            optimizer = new Optimizer(operationsRegistry);
            decompiler = new Decompiler(operationsRegistry);
        }
    }
}
