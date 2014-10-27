namespace UserStoryEditor
{
    using FluentAssertions;

    using Xbehave;

    public class SpecsRunning
    {
        [Scenario]
        public void Failing(
            int i)
        {
            "establish pre-condition"._(() =>
                i = 17);

            "when executing action"._(() =>
                i += 25);

            "it should succeed in happy case"._(() =>
                i.Should().Be(42));

            "it should fail in error case"._(() =>
                i.Should().Be(17));
        }
    }
}