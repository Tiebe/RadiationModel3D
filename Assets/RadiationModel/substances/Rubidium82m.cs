
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium82m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium82m";
        public override double halfLife { get; } = 23299.2d;
        public override double atomicWeight { get; } = 81.91828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton82() } },

            { 0.0033d, new List<RadioactiveSubstance> { new GammaParticle(), new Rubidium82() } },

        };
    }
}
    
    