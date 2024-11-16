using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine204m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine204m";
        public override double halfLife { get; } = 0.108d;
        public override double atomicWeight { get; } = 203.98788d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((587000.0, 0.00211)), new Astatine204() } },

        };
    }
}
    
    