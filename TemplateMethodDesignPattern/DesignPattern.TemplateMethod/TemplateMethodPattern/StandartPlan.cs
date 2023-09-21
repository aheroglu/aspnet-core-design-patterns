namespace DesignPattern.TemplateMethod.TemplateMethodPattern
{
    public class StandartPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int PersonCount(int count)
        {
            return count;
        }

        public override string PlanType(string type)
        {
            return type;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resolution(string resolution)
        {
            return resolution;
        }
    }
}
