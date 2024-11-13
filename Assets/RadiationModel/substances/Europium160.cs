
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium160";
        public override double halfLife { get; } = 42.6d;
        public override double atomicWeight { get; } = 159.93184d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium160() } },

        };
    }
}
    
    