
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium150";
        public override double halfLife { get; } = 430.2d;
        public override double atomicWeight { get; } = 149.92559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.664d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium150() } },

            { 0.336d, new List<RadioactiveSubstance> { new AlphaParticle(), new Gadolinium146() } },

        };
    }
}
    
    