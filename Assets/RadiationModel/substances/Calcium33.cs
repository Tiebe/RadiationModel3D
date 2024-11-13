
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium33 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium33";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 33.03331d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    