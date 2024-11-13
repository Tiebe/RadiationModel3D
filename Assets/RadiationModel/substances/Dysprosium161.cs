
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium161";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 160.92694d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    