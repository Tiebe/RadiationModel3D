
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium196m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium196m";
        public override double halfLife { get; } = 5076.0d;
        public override double atomicWeight { get; } = 195.9709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9620000000000001d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury196() } },

            { 0.038d, new List<RadioactiveSubstance> { new GammaParticle(), new Thallium196() } },

        };
    }
}
    
    