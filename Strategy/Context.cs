namespace Strategy
{
    public class Context
    {
        private  IStrategy strategy;

        public Context(IStrategy strategy)
        {
            setStrategy(strategy);
        }

        public void setStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public virtual void Operation()
        {
            this.strategy.PerformStrategy();
        }
    }
}