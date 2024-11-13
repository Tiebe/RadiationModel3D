
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin111 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin111";
        public override double halfLife { get; } = 2118.0d;
        public override double atomicWeight { get; } = 110.90774d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium111() } },

        };
    }
}
    
    