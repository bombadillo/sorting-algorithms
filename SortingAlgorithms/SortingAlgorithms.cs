namespace SortingAlgorithms
{
    using Interfaces;

    class SortingAlgorithms
    {
        static void Main(string[] args)
        {
            CompositionRoot.Wire(new ApplicationModule());

            var app = CompositionRoot.Resolve<IApp>();

            app.Run();
        }
    }
}
