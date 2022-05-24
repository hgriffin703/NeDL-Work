using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    class CalcController
    {
        private CalcModel calcModel;
        private CalcView calcView;

        public CalcController()
        {
            calcView = new CalcView();
            calcModel = new CalcModel(calcView.Number1, calcView.Number2);
            calcView.Addition = calcModel.Addition();
            calcView.Subtraction = calcModel.Subtraction();
            calcView.Multiplication = calcModel.Multiplication();
            calcView.Division = calcModel.Division();
            calcView.GetMathOption();
        }
    }
}

