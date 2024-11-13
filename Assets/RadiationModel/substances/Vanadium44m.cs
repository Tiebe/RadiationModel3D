
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium44m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium44m";
        public override double halfLife { get; } = 0.15d;
        public override double atomicWeight { get; } = 43.97473d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium44() } },

        };
    }
}
    
    