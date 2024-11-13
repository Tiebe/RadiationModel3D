
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium109m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium109m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 108.90505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Cadmium109() } },

        };
    }
}
    
    