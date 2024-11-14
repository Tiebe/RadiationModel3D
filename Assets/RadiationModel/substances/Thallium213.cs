using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium213";
        public override double halfLife { get; } = 23.8d;
        public override double atomicWeight { get; } = 213.00192d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4988000.0), new Lead213() } },

        };
    }
}
    
    