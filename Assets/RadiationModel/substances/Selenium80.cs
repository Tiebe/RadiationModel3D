using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium80";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 79.91652d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    