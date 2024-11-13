
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium64";
        public override double halfLife { get; } = 157.62d;
        public override double atomicWeight { get; } = 63.93684d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc64() } },

        };
    }
}
    
    