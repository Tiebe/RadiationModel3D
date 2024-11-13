
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium137";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 136.96153d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin137() } },

        };
    }
}
    
    