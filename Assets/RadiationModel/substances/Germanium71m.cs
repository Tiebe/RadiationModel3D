using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium71m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium71m";
        public override double halfLife { get; } = 0.02041d;
        public override double atomicWeight { get; } = 70.92517d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00625), new Germanium71() } },

        };
    }
}
    
    