
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen22 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen22";
        public override double halfLife { get; } = 2.25d;
        public override double atomicWeight { get; } = 22.00996d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fluorine22() } },

        };
    }
}
    
    