
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium74 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium74";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 73.92248d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    