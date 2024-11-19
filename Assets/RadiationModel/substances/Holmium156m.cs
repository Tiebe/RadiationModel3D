using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium156m";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 155.92969d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0248, 50000.0), new Holmium156() } },

        };
    }
}
    
    