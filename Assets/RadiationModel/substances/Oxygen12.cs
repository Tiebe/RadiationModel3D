using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen12 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen12";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 12.03437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Carbon10() } },

        };
    }
}
    
    