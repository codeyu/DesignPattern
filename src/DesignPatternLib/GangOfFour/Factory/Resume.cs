using System.Collections.Generic;

namespace DesignPatternLib.Factory
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages = new List<Page>
              { new SkillsPage(), 
                new EducationPage(), 
                new ExperiencePage() };
        }
    }
}