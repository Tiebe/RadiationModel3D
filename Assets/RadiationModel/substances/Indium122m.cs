
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium122m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium122m";
        public override double halfLife { get; } = 10.3d;
        public override double atomicWeight { get; } = 121.91033d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin122() } },

        };
    }
}
    
    