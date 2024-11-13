
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium85m";
        public override double halfLife { get; } = 4057.8d;
        public override double atomicWeight { get; } = 84.91319d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.866d, new List<RadioactiveSubstance> { new GammaParticle(), new Strontium85() } },

            { 0.134d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium85() } },

        };
    }
}
    
    