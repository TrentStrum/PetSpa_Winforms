using System.ComponentModel;

namespace TT.Forms.Classes
{
    public static class Extensions
    {
        public static void BindEnumToCombobox<T>(this ComboBox comboBox, T defaultSelection)
        {
            var list = Enum.GetValues(typeof(T)).Cast<T>()
                .Select(value => new
                {
                    Description = (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description ?? value.ToString(),
                    Value = value
                })
                //.OrderBy(item => item.Value.ToString())
                .ToList();

            comboBox.DataSource = list;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";

            foreach (var opts in list)
            {
                if (opts.Description.ToString() == defaultSelection.ToString())
                {
                    comboBox.SelectedItem = opts;
                }
            }
        }

        public static void AddDataBinding(this TextBox textBox, object dataSource, string dataMember)
        {
            textBox.DataBindings.Add("Text", dataSource, dataMember);
        }
        public static void AddDataBindingComboBox(this ComboBox comboBox, object dataSource, string dataMember)
        {
            comboBox.DataBindings.Add("Text", dataSource, dataMember);
        }
        public static void AddDataBindingDateTime(this DateTimePicker dateTimePicker, object dataSource, string dataMember)
        {
            dateTimePicker.DataBindings.Add("DateTime", dataSource, dataMember);
        }
    }
}
 