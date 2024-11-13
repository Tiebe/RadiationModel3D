
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium78";
        public override double halfLife { get; } = 1059.6d;
        public override double atomicWeight { get; } = 77.92814d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton78() } },

        };
    }
}
    
    