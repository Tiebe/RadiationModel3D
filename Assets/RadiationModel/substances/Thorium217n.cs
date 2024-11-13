
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium217n : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium217n";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 217.01558d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Thorium217() } },

        };
    }
}
    
    