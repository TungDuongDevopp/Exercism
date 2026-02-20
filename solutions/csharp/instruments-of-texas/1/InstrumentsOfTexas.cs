public class CalculationException : Exception{
    public CalculationException(int operand1, int operand2, string message, Exception inner) : base(message, inner){  
        Operand1 = operand1;
        Operand2 = operand2;  
    }

    public int Operand1 { get; }
    public int Operand2 { get; }
}

public class CalculatorTestHarness{
    private Calculator calculator;
    
    public CalculatorTestHarness(Calculator calculator){
        this.calculator = calculator;
    }

   public string TestMultiplication(int x, int y){
    try{
        Multiply(x, y);
        return "Multiply succeeded";
    }
    catch (CalculationException ex){
        return ex.Message;
    }
}

    public void Multiply(int x, int y){
        try{
            calculator.Multiply(x, y);
        }
        catch (OverflowException ex){
            var message ="Multiplication caused overflow.";
               if (x < 0 && y < 0){
                message = "Multiply failed for negative operands. Arithmetic operation resulted in an overflow.";
            }
            else{
                message = "Multiply failed for mixed or positive operands. Arithmetic operation resulted in an overflow.";
            }
            throw new CalculationException(
            x,
            y,
            message,
            ex);
        }
    }
}

public class Calculator{
    public int Multiply(int x, int y){
        checked{
            return x * y;
        }
    }
}
