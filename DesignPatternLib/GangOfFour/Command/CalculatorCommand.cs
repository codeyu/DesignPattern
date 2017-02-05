using System;

namespace DesignPatternLib.Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    class CalculatorCommand : ICommand
    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;
        // Constructor
        public CalculatorCommand(Calculator calculator,
            char @operator, int operand)
        {
            this._calculator = calculator;
            this._operator = @operator;
            this._operand = operand;
        }
        // Sets operator
        public char Operator
        {
            set { _operator = value; }
        }
        // Sets operand
        public int Operand
        {
            set { _operand = value; }
        }
        // Execute command
        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }
        // Unexecute command
        public void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }
        // Return opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new
                  ArgumentException("@operator");
            }
        }
    }
}