
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury181m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury181m";
        public override double halfLife { get; } = 0.00048d;
        public override double atomicWeight { get; } = 180.97805d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Mercury181() } },

        };
    }
}
    
    