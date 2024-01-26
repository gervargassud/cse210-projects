using System;
public class Function {

public Function(){
    _top = 1;
    _bottom = 1;
}  
public Function(int number){
    _top = number;
    _bottom = 1;

}

public Function(int number1, int number2){
    _top = number1;
    _bottom = number2;

}

private int _top;
private int _bottom;

public int GetTop(){
    return _top;
}
public int GetBottom(){
    return _bottom;
}
public void SetBottom(int bottom){
    _bottom = bottom;

}
public void SetTop(int top){
    _top = top;

}

public String GetFractionString(){
    String text = $"{_top} / {_bottom}";
    return text;
}
public double GetDecimalValue(){
   return (double) _top / (double)  _bottom;
}


}