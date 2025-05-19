namespace Blackjack
{
    public class CardDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CardTemplate { get; set; }
        public DataTemplate FacedownTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Card)item).IsFacedown ? FacedownTemplate : CardTemplate;
        }
    }
}
