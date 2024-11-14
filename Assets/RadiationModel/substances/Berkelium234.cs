using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium234";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 234.05733d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new List<RadioactiveSubstance> { new AlphaParticle(9125047.4), new Americium230() } },
            { 0.2d, new List<RadioactiveSubstance> { new BetaParticle(1, 6678000.0), new Curium234() } },

        };
    }
}
    
    