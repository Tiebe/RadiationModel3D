using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine80m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine80m";
        public override double halfLife { get; } = 15913.8d;
        public override double atomicWeight { get; } = 79.91862d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01445), new Bromine80() } },

        };
    }
}
    
    