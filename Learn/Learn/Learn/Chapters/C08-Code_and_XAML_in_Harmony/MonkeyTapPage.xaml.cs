using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Learn.Chapters.C08_Code_and_XAML_in_Harmony
{
  public partial class MonkeyTapPage : ContentPage
  {
    const Int32 sequenceTime = 750;
    protected const Int32 flashDuration = 250;

    const Double offLuminosity = 0.4;
    const Double onLuminosity = 0.75;

    BoxView[] boxViews;
    Color[] colors = { Color.Red, Color.Blue, Color.Yellow, Color.Green };
    List<Int32> sequence = new List<Int32>();
    Int32 sequenceIndex;
    Boolean awaitingTaps;
    Boolean gameEnded;
    Random random = new Random();

    public MonkeyTapPage()
    {
      InitializeComponent();

      boxViews = new BoxView[] { boxView0, boxView1, boxView2, boxView3 };

      InitializeBoxViewColors();
    }

    void InitializeBoxViewColors()
    {
      for (int index = 0; index < 4; index++)
      {
        boxViews[index].Color = colors[index].WithLuminosity(offLuminosity);
      }
    }

    void OnStartGameButtonClicked(object sender, EventArgs e)
    {
      gameEnded = false;
      startGameButton.IsVisible = false;
      InitializeBoxViewColors();
      sequence.Clear();
      StartSequence();
    }

    private void StartSequence()
    {
      sequence.Add(random.Next(4));
      sequenceIndex = 0;
      Device.StartTimer(TimeSpan.FromMilliseconds(sequenceTime), OnTimerTick);
    }

    private bool OnTimerTick()
    {
      if (gameEnded) return false;

      FlashBoxView(sequence[sequenceIndex]);
      sequenceIndex++;
      awaitingTaps = sequenceIndex == sequence.Count;
      sequenceIndex = awaitingTaps ? 0 : sequenceIndex;

      return !awaitingTaps;
    }

    protected virtual void FlashBoxView(int index)
    {
      boxViews[index].Color = colors[index].WithLuminosity(onLuminosity);
      Device.StartTimer(TimeSpan.FromMilliseconds(flashDuration), () =>
      {
        if (gameEnded) return false;

        boxViews[index].Color = colors[index].WithLuminosity(offLuminosity);
        return false;
      });
    }

    protected void OnBoxViewTapped(object sender, EventArgs e)
    {
      if (gameEnded) return;

      if (!awaitingTaps)
      {
        EndGame();
        return;
      }

      var tappedBoxView = (BoxView)sender;
      var index = Array.IndexOf(boxViews, tappedBoxView);

      if (index != sequence[sequenceIndex])
      {
        EndGame();
        return;
      }

      FlashBoxView(index);

      sequenceIndex++;
      awaitingTaps = sequenceIndex < sequence.Count;

      if (!awaitingTaps) StartSequence();
    }

    protected virtual void EndGame()
    {
      gameEnded = true;

      for (int index = 0; index < 4; index++)
      {
        boxViews[index].Color = Color.Gray;
      }

      startGameButton.Text = "Try again?";
      startGameButton.IsVisible = true;
    }
  }
}
