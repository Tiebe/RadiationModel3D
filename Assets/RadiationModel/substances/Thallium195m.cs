
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium195m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium195m";
        public override double halfLife { get; } = 3.6d;
        public override double atomicWeight { get; } = 194.97029d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Thallium195() } },

        };
    }
}
    
    