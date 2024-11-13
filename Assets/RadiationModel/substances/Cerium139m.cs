
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium139m";
        public override double halfLife { get; } = 57.58d;
        public override double atomicWeight { get; } = 138.90746d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Cerium139() } },

        };
    }
}
    
    