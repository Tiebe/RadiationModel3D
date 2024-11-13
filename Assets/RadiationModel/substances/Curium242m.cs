
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium242m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium242m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 242.06184d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    