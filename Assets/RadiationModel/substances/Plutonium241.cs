using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium241";
        public override double halfLife { get; } = 452179565.208d;
        public override double atomicWeight { get; } = 241.05685d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 20800.0), new Americium241() } },
            { 2.45e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6160047.4), new Uranium237() } },
            { 2.4e-16d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    