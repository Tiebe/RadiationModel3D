
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium126m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium126m";
        public override double halfLife { get; } = 1.64d;
        public override double atomicWeight { get; } = 125.91657d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin126() } },

        };
    }
}
    
    