
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

            { 0.976d, new List<RadioactiveSubstance> { new GammaParticle(), new Bromine82() } },

            { 0.024d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton82() } },

        };
    }
}
    
    