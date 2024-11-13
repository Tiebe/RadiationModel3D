
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium153";
        public override double halfLife { get; } = 23040.0d;
        public override double atomicWeight { get; } = 152.92577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.999906d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium153() } },

            { 9.400000000000001e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Gadolinium149() } },

        };
    }
}
    
    