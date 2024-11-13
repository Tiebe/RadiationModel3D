
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic65 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic65";
        public override double halfLife { get; } = 0.1303d;
        public override double atomicWeight { get; } = 64.94961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium65() } },

        };
    }
}
    
    