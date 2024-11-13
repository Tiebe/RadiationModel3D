
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese48i : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese48i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 47.97181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Chromium47() } },

        };
    }
}
    
    