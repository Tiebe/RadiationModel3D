
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium86";
        public override double halfLife { get; } = 0.2216d;
        public override double atomicWeight { get; } = 85.94697d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Arsenic86() } },

        };
    }
}
    
    