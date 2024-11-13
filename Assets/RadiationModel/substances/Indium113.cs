
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium113";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 112.90406d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    