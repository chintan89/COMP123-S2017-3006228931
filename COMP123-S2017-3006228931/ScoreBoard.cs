using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name - Chintan Patel
 * Student # 300622893
 * Date - Aug 17, 2017
 * Description - Pick Higest Card
 * Version: 0.2 ScoreBoardClass Created
 */
namespace COMP123_S2017_3006228931
{
    class ScoreBoard
    {
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
    }
    public TextBox FinalScoreTextBox
    {
        get
        {
            return this._finalscoretextbox;
        }
        set
        {
            this._finalscoretextbox = value;
            this.score = Covert.ToInt32(this.FinalScoreTextBox.text)
        }
    }

}
