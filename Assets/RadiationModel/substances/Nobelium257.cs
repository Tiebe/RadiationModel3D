
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium257";
        public override double halfLife { get; } = 24.5d;
        public override double atomicWeight { get; } = 257.09688d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.85d, new List<RadioactiveSubstance> { new AlphaParticle(), new Fermium253() } },

            { 0.15d, new List<RadioactiveSubstance> { new BetaParticle(), new Mendelevium257() } },

        };
    }
}
    
    