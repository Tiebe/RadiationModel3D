using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium38 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium38";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 37.99544d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    