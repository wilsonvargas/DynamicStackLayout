using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DynamicStackLayout.Controls
{
    public class DynamicStackLayout : StackLayout
    {
        public IEnumerable<object> ItemsSource
        {
            get { return (IEnumerable<object>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(
                propertyName: nameof(ItemsSource),
                returnType: typeof(IEnumerable<object>),
                declaringType: typeof(DynamicStackLayout),
                propertyChanged: OnItemsSourceChanged);

        public static readonly BindableProperty ItemTemplateProperty =
                                   BindableProperty.Create(
               propertyName: nameof(ItemTemplate),
               returnType: typeof(DataTemplate),
               declaringType: typeof(DynamicStackLayout),
               defaultValue: default(DataTemplate),
               propertyChanged: OnItemTemplateChanged);

        public static object CreateContent(DataTemplate template, object item, BindableObject container)
        {
            var selector = template as DataTemplateSelector;
            if (selector != null)
            {
                template = selector.SelectTemplate(item, container);
            }

            return template.CreateContent();
        }

        private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var layout = (DynamicStackLayout)bindable;
            if (newValue == null)
            {
                return;
            }

            layout.PopulateItems();
        }

        private static void OnItemTemplateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var layout = (DynamicStackLayout)bindable;
            if (newValue == null)
            {
                return;
            }

            layout.PopulateItems();
        }

        private View InflateView(object viewModel)
        {
            var view = (View)CreateContent(ItemTemplate, viewModel, this);
            view.BindingContext = viewModel;
            return view;
        }

        private void PopulateItems()
        {
            var items = ItemsSource;
            if (items == null || ItemTemplate == null)
            {
                return;
            }

            var children = Children;
            children.Clear();

            foreach (var item in items)
            {
                children.Add(InflateView(item));
            }
        }
    }
}
