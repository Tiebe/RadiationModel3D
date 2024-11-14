using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon36 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon36";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 35.96755d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    