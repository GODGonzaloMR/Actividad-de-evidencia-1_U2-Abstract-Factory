<html>
<body>
    
# Instituto Tecnológico

## Materia: Patrones de Diseño

---

# Actividad de Evidencia 1 – Unidad 2

## Implementación del Patrón Abstract Factory

---

**Alumno:** Gonzalo Cortez Huerta

**Número de Control:** 22210761

**Materia:** Patrones de Diseño

**Actividad:** Actividad de Evidencia 1_U2 – Abstract Factory

**Profesor:** *(Maribel Guerrero Luis)*

**Carrera:** *(Sistemas Computacionales)*

**Fecha:** *(4 de marzo del 2026)*

[![Chat-GPT-Image-5-mar-2026-03-03-05.png](https://i.postimg.cc/VLTLXGqZ/Chat-GPT-Image-5-mar-2026-03-03-05.png)](https://postimg.cc/svYrrJ05)

<!--StartFragment--><html><head></head><body><h1>Patrón de Diseño Abstract Factory </h1><h2>2. Introducción al patrón Abstract Factory</h2><p>El <strong>patrón de diseño Abstract Factory</strong> pertenece a los <strong>patrones creacionales</strong>, cuyo objetivo es crear familias de objetos relacionados sin especificar sus clases concretas.</p><p>Este patrón permite que un sistema sea independiente de cómo se crean, componen o representan los objetos. En lugar de crear objetos directamente con <code inline="">new</code>, se utilizan <strong>fábricas abstractas</strong> que definen métodos para crear los objetos, y posteriormente <strong>fábricas concretas</strong> que implementan dichas creaciones.</p><p>En el contexto educativo, el patrón puede utilizarse para crear diferentes <strong>modalidades de enseñanza</strong>, donde cada modalidad genera su propia <strong>guía de estudio</strong> y <strong>tipo de examen</strong>.</p>

[![image.png](https://i.postimg.cc/wBTPvFCz/image.png)](https://postimg.cc/BjkN75Z7)


<p>De esta forma, el sistema puede cambiar de modalidad <strong>sin modificar el código principal</strong>, únicamente cambiando la fábrica utilizada.</p><hr><h1>3. Código implementado (con modalidad híbrida)</h1><h2>Productos abstractos</h2><pre><code class="language-csharp">interface IGuia
{
    void mostrar();
}

interface IExamen
{
    void aplicar();
}

[![image.png](https://i.postimg.cc/ncJ3r0m7/image.png)](https://postimg.cc/QVfQng0x)

</code></pre><hr><h2>Fábrica abstracta</h2><pre><code class="language-csharp">interface IFabricaEducacion
{
    IGuia crearGuia();
    IExamen crearExamen();
}

[![image.png](https://i.postimg.cc/QxfcDbJs/image.png)](https://postimg.cc/PP8Cz17F)

</code></pre><hr><h1>IMPLEMENTACIÓN PRESENCIAL</h1><pre><code class="language-csharp">class GuiaImpresa : IGuia
{
    public void mostrar()
    {
        Console.WriteLine("Mostrando la guia impresa");
    }
}

class ExamenPapel : IExamen
{
    public void aplicar()
    {
        Console.WriteLine("Se aplica examen en papel");
    }
}

class FabricaPresencial : IFabricaEducacion
{
    public IGuia crearGuia()
    {
        return new GuiaImpresa();
    }

    public IExamen crearExamen()
    {
        return new ExamenPapel();
    }
}

[![image.png](https://i.postimg.cc/Pr58SDnX/image.png)](https://postimg.cc/QVvttHMw)

</code></pre><hr><h1>IMPLEMENTACIÓN VIRTUAL</h1><pre><code class="language-csharp">class GuiaPDF : IGuia
{
    public void mostrar()
    {
        Console.WriteLine("Mostrando la guia PDF");
    }
}

class ExamenLinea : IExamen
{
    public void aplicar()
    {
        Console.WriteLine("Se aplica examen en linea");
    }
}

class FabricaVirtual : IFabricaEducacion
{
    public IGuia crearGuia()
    {
        return new GuiaPDF();
    }

    public IExamen crearExamen()
    {
        return new ExamenLinea();
    }
}

[![image.png](https://i.postimg.cc/T1YhNzS7/image.png)](https://postimg.cc/bDWzsBqk)

</code></pre><hr><h1>IMPLEMENTACIÓN HÍBRIDA</h1><pre><code class="language-csharp">class GuiaHibrida : IGuia
{
    public void mostrar()
    {
        Console.WriteLine("Mostrando la guia en modalidad hibrida (semipresencial)");
    }
}

class ExamenMixto : IExamen
{
    public void aplicar()
    {
        Console.WriteLine("Se aplica examen mixto");
    }
}

class FabricaHibrida : IFabricaEducacion
{
    public IGuia crearGuia()
    {
        return new GuiaHibrida();
    }

    public IExamen crearExamen()
    {
        return new ExamenMixto();
    }
}

[![image.png](https://i.postimg.cc/J4S4jH1b/image.png)](https://postimg.cc/3dCTTR0R)

</code></pre><hr><h1>PROGRAMA PRINCIPAL</h1><pre><code class="language-csharp">

class Program
{
    static void ejecutar(IFabricaEducacion fabrica)
    {
        IGuia guia = fabrica.crearGuia();
        IExamen examen = fabrica.crearExamen();

        guia.mostrar();
        examen.aplicar();
        Console.WriteLine();
    }

    static void Main()
    {
        ejecutar(new FabricaPresencial());
        ejecutar(new FabricaVirtual());
        ejecutar(new FabricaHibrida());
    }
}

[![image.png](https://i.postimg.cc/rw6MD6J7/image.png)](https://postimg.cc/56mZrRDm)

</code></pre><hr><h1>Ejecución</h1><p>Salida en la terminal:</p><pre><code>Mostrando la guia impresa
Se aplica examen en papel

Mostrando la guia PDF
Se aplica examen en linea

Mostrando la guia en modalidad hibrida (semipresencial)
Se aplica examen mixto

[![image.png](https://i.postimg.cc/g2PbYVcF/image.png)](https://postimg.cc/RNGDdnnX)

</code></pre><hr><h1>4. Conclusión del patrón y de la implementación</h1><p>El patrón <strong>Abstract Factory</strong> permite crear diferentes familias de objetos relacionados sin depender de clases concretas. Esto facilita que el sistema sea <strong>más flexible, reutilizable y fácil de mantener</strong>.</p><p>En la implementación realizada se modelaron tres modalidades educativas:</p><ul><li><p>Modalidad presencial</p></li><li><p>Modalidad virtual</p></li><li><p>Modalidad híbrida</p></li></ul><p>Cada modalidad genera su propia <strong>guía de estudio</strong> y <strong>tipo de examen</strong>, lo que demuestra cómo el patrón permite agregar nuevas variantes sin modificar la estructura principal del programa.</p><p>La incorporación de la <strong>modalidad híbrida</strong> muestra una de las principales ventajas del patrón: <strong>la extensibilidad</strong>, ya que fue posible añadir una nueva modalidad creando nuevas clases sin alterar el funcionamiento del sistema existente.</p></body></html><!--EndFragment-->
</body>
</html>
