using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium76 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium76";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 75.91921d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    