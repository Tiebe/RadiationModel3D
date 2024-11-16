using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium212";
        public override double halfLife { get; } = 31.0d;
        public override double atomicWeight { get; } = 211.99834d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5998900.0), new Lead212() } },

        };
    }
}
    
    