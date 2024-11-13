
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium84m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium84m";
        public override double halfLife { get; } = 1215.6d;
        public override double atomicWeight { get; } = 83.91487d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Rubidium84() } },

            { 1.1999999999999999e-05d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton84() } },

        };
    }
}
    
    