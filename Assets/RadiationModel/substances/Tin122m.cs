
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin122m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin122m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 121.90603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tin122() } },

        };
    }
}
    
    