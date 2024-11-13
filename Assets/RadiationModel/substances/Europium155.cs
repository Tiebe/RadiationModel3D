
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium155";
        public override double halfLife { get; } = 149643066.384d;
        public override double atomicWeight { get; } = 154.9229d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium155() } },

        };
    }
}
    
    