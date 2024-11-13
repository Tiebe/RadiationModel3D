
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium87m";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 86.91518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Zirconium87() } },

        };
    }
}
    
    