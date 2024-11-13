
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine27 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine27";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 27.02698d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neon27() } },

        };
    }
}
    
    