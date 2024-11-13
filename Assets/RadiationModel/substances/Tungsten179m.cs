
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten179m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten179m";
        public override double halfLife { get; } = 384.0d;
        public override double atomicWeight { get; } = 178.94732d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tungsten179() } },

            { 0.0029d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum179() } },

        };
    }
}
    
    