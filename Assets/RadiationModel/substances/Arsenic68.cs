
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic68 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic68";
        public override double halfLife { get; } = 151.6d;
        public override double atomicWeight { get; } = 67.93677d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium68() } },

        };
    }
}
    
    