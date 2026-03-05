using System;

// Productos abstractos
interface IGuia
{
    void mostrar();
}

interface IExamen
{
    void aplicar();
}

// Fábrica abstracta
interface IFabricaEducacion
{
    IGuia crearGuia();
    IExamen crearExamen();
}

// ===== IMPLEMENTACION PRESENCIAL =====

class GuiaImpresa : IGuia
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

// ===== IMPLEMENTACION VIRTUAL =====

class GuiaPDF : IGuia
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

// ===== IMPLEMENTACION HIBRIDA =====

class GuiaHibrida : IGuia
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

// ===== PROGRAMA PRINCIPAL =====

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