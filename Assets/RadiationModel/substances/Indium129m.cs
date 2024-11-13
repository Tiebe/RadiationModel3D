
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium129m";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 128.92229d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin129() } },

        };
    }
}
    
    