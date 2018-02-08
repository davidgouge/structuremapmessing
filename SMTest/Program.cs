using System;
using SFA.DAS.AssessmentOrgs.Api.Client;
using StructureMap;

namespace SMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(cfg =>
            {
                cfg.For<ISomeInterface>().Use<SomeImplementation>();
            });

            var cli = container.GetInstance<IAssessmentOrgsApiClient>();

            Console.ReadKey();
        }
    }


    public interface ISomeInterface
    {
        
    }

    public class SomeImplementation : ISomeInterface
    {
        public SomeImplementation(string arg = null)
        {
            
        }
    }

}
