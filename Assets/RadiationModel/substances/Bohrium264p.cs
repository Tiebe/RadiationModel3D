using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium264p : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium264p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 264.12484d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    