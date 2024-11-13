
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium79";
        public override double halfLife { get; } = 18.98d;
        public override double atomicWeight { get; } = 78.92536d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Arsenic79() } },

        };
    }
}
    
    