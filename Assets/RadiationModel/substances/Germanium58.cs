using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium58";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 57.99186d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    