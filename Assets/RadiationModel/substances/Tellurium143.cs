
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium143";
        public override double halfLife { get; } = 0.12d;
        public override double atomicWeight { get; } = 142.95649d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine143() } },

        };
    }
}
    
    