using CCLibrary.MockStubs;
using FakeItEasy;
using Xunit;

namespace CCLibrary.Tests.MockStubs
{
    public class Copier_Should
    {
        [Fact]
        public void Copy_one_char()
        {
            var sourceMock = A.Fake<ISource>();
            var destinationStub = A.Fake<IDestination>();
            var copier = new Copier(sourceMock, destinationStub);

            A.CallTo(() => sourceMock.GetChar()).ReturnsNextFromSequence('a','\n');
            copier.Copy();

            A.CallTo(() => destinationStub.SetChar('a')).MustHaveHappened();
        }

        [Fact]
        public void Copy_string_of_two_chars()
        {
            var sourceMock = A.Fake<ISource>();
            var destinationStub = A.Fake<IDestination>();
            var copier = new Copier(sourceMock, destinationStub);

            A.CallTo(() => sourceMock.GetChar()).ReturnsNextFromSequence('a','b','\n');
            copier.Copy();

            A.CallTo(() => destinationStub.SetChar('a')).MustHaveHappened();
            A.CallTo(() => destinationStub.SetChar('b')).MustHaveHappened();
        }

        [Fact]
        public void Not_copy_newline()
        {
            var sourceMock = A.Fake<ISource>();
            var destinationStub = A.Fake<IDestination>();
            var copier = new Copier(sourceMock, destinationStub);

            A.CallTo(() => sourceMock.GetChar()).Returns('\n');

            copier.Copy();

            A.CallTo(() => destinationStub.SetChar('\n')).MustNotHaveHappened();

        }

        [Fact]
        public void Copy_two_chars_and_stop_at_newline()
        {
            var sourceMock = A.Fake<ISource>();
            var destinationStub = A.Fake<IDestination>();
            var copier = new Copier(sourceMock, destinationStub);

            A.CallTo(() => sourceMock.GetChar()).ReturnsNextFromSequence('a','b','\n','c');

            copier.Copy();

            A.CallTo(() => destinationStub.SetChar('a')).MustHaveHappened();
            A.CallTo(() => destinationStub.SetChar('b')).MustHaveHappened();
            A.CallTo(() => destinationStub.SetChar('c')).MustNotHaveHappened();

        }
    }
}
