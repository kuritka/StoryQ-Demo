using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoryQ.Test.Framework
{
    
    [TestClass]
	public partial class StoryQSpecBase
	{
		
		/// <summary>
		/// Gets or sets the story.
		/// </summary>
		/// <value>The story.</value>
		protected Feature MyFeature { get; set; }
		protected Outcome LastOutcome { get; set; }

		/// <summary>
		/// Creates the scenario.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <returns></returns>
		protected virtual Scenario WithScenario(string text)
		{
			return LastOutcome == null ? MyFeature.WithScenario(text) : LastOutcome.WithScenario(text);
		}

		protected virtual Scenario Scenario
		{
			get
			{
				return WithScenario(StoryQHelper.ConvertTestMethodAsScenario());
			}
		}
    }
}
