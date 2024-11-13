
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine38 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine38";
        public override double halfLife { get; } = 2233.8d;
        public override double atomicWeight { get; } = 37.96801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Argon38() } },

        };
    }
}
    
    