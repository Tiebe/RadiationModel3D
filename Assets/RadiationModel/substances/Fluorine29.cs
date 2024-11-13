
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine29 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine29";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 29.0431d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neon29() } },

        };
    }
}
    
    