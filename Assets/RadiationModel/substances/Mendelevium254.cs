
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium254";
        public override double halfLife { get; } = 600.0d;
        public override double atomicWeight { get; } = 254.08959d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Fermium254() } },

        };
    }
}
    
    