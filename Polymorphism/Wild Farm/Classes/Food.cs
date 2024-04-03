

namespace WildFarm.classes
{
    public abstract class Food
    {

        private int quantity;

        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}
