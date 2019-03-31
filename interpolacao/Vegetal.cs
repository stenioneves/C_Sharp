using System;

namespace interpolacao{

  class Vegetal{
    
    public Vegetal(string name)=> Name=name;// Arrow onde tem o paramentro o Atributo da classe e a variavel local recebida.

    public string Name {get;}

    public override string ToString()=> Name; //Arrow ja retorna o Atributo Name da classe,sem muita implementação.


  }


  public enum Unidade {item,quilograma, grama,doze}



}