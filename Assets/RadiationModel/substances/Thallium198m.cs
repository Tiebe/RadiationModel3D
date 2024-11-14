using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium198m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium198m";
        public override double halfLife { get; } = 6732.0d;
        public override double atomicWeight { get; } = 197.97103d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5589999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 3969300.0), new Mercury198() } },
            { 0.441d, new List<RadioactiveSubstance> { new GammaParticle(0.00228), new Thallium198() } },

        };
    }
}
    
    