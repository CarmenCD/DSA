namespace DesignPatterns.Factory.AbstractFactory
{
    public abstract class PizzaStore
    {
        // operation method
        public Pizza  OrderPizza(string type)
        {
            Pizza p = CreatePizza(type);
            Pizza.Prepare();
            Pizza.Bake();
            Pizza.Cut();
            Pizza.Box();

            return p;
        }

        //factory method
        protected abstract Pizza CreatePizza(string type);
    }
}
