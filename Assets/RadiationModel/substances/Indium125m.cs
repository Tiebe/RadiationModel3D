
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium125m";
        public override double halfLife { get; } = 12.2d;
        public override double atomicWeight { get; } = 124.91405d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin125() } },

        };
    }
}
    
    