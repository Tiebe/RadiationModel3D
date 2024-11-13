
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium169";
        public override double halfLife { get; } = 0.75d;
        public override double atomicWeight { get; } = 168.95288d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium169() } },

        };
    }
}
    
    