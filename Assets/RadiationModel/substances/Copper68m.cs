
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper68m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper68m";
        public override double halfLife { get; } = 225.0d;
        public override double atomicWeight { get; } = 67.93039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.86d, new List<RadioactiveSubstance> { new GammaParticle(), new Copper68() } },

            { 0.14d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc68() } },

        };
    }
}
    
    