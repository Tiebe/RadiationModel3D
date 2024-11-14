using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium256p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium256p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 256.09415d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    