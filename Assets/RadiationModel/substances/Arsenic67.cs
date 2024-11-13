
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic67 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic67";
        public override double halfLife { get; } = 42.5d;
        public override double atomicWeight { get; } = 66.93925d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium67() } },

        };
    }
}
    
    