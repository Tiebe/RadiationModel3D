
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium138";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 137.95319d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Gadolinium137() } },

        };
    }
}
    
    