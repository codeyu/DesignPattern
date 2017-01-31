using System.Collections.Generic;

namespace DesignPatternLib.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages = new List<Page>
                { new IntroductionPage(), 
                  new ResultsPage(),
                  new ConclusionPage(),
                  new SummaryPage(),
                  new BibliographyPage() };
        }
    }
}