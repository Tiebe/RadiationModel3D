using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum198 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum198";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 197.9679d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    