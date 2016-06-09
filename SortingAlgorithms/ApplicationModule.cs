﻿namespace SortingAlgorithms
{
    using Ninject.Modules;
    using NLog;
    using Interfaces;
    using Classes;

    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IApp)).To(typeof(App));
            Bind<ILog>().ToMethod(x =>
            {
                var scope = x.Request.ParentRequest.Service.FullName;
                var log = (ILog)LogManager.GetLogger(scope, typeof(Log));
                return log;
            });
            Bind(typeof(IBubbleSort)).To(typeof(BubbleSorter));
            Bind(typeof(IQuickSort)).To(typeof(QuickSorter));
        }
    }
}
