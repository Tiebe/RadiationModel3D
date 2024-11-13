
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium141";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 140.93213d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium141() } },

        };
    }
}
    
    