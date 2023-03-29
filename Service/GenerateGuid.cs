namespace InjectionDependence.Console.Service
{
    public class GenerateGuid : IGenerateGuid
    {
         public Guid Id {get; set;} 

         public GenerateGuid() => Id = Guid.NewGuid();
    }
}