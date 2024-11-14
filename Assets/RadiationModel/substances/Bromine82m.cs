using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine82m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine82m";
        public override double halfLife { get; } = 367.8d;
        public override double atomicWeight { get; } = 81.91685d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.976d, new List<RadioactiveSubstance> { new GammaParticle(0.02701), new Bromine82() } },
            { 0.024d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3138995.0), new Krypton82() } },

        };
    }
}
    
    