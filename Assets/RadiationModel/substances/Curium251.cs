
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium251";
        public override double halfLife { get; } = 1008.0d;
        public override double atomicWeight { get; } = 251.08229d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Berkelium251() } },

        };
    }
}
    
    