using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium56";
        public override double halfLife { get; } = 0.026d;
        public override double atomicWeight { get; } = 55.9726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13900000.0), new Titanium56() } },

        };
    }
}
    
    