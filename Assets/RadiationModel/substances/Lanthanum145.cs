
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum145 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum145";
        public override double halfLife { get; } = 24.8d;
        public override double atomicWeight { get; } = 144.92181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium145() } },

        };
    }
}
    
    