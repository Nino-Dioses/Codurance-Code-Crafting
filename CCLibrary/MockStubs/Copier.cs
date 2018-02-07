namespace CCLibrary.MockStubs
{
    public class Copier
    {
        private IDestination destinationStub;
        private ISource sourceMock;

        public Copier(ISource sourceMock, IDestination destinationStub)
        {
            this.sourceMock = sourceMock;
            this.destinationStub = destinationStub;
        }

        public void Copy()
        {
            char sourceChar;
            do
            {
                sourceChar = sourceMock.GetChar();
                if (sourceChar != '\n')
                {
                    this.destinationStub.SetChar(sourceChar);
                }

            } while (sourceChar != '\n');

        }
    }
}
