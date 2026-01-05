namespace osu_trainer.Controls
{
    public class ScrollableTextBox : TextBox
    {
        public int ScrollValue;

        public ScrollableTextBox()
        {
            DoubleBuffered = true;
            Invalidate();
            ScrollValue = 5;
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            int number;
            if (!int.TryParse(Text, out number))
                return;

            if (e.Delta > 0 || e.Delta < 0)
            {
                do { number += (e.Delta > 0) ? 1 : (e.Delta < 0) ? -1 : 1; } while (number % ScrollValue != 0);
            }
            Text = number.ToString();
            OnLeave(EventArgs.Empty);
        }
    }
}
