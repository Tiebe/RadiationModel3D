using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium186n : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium186n";
        public override double halfLife { get; } = 3.4d;
        public override double atomicWeight { get; } = 185.97908d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.941d, new List<RadioactiveSubstance> { new GammaParticle(0.00315, 393000.0), new Thallium186() } },
            { 0.059000000000000004d, new List<RadioactiveSubstance> { new BetaParticle(1, 9049000.0), new Mercury186() } },

        };
    }
}
    
    