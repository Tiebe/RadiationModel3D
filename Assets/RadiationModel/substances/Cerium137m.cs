
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium137m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium137m";
        public override double halfLife { get; } = 123840.0d;
        public override double atomicWeight { get; } = 136.90804d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9921d, new List<RadioactiveSubstance> { new GammaParticle(), new Cerium137() } },

            { 0.0079d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum137() } },

        };
    }
}
    
    