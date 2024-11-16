using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium177m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium177m";
        public override double halfLife { get; } = 0.00023d;
        public override double atomicWeight { get; } = 176.99728d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new List<RadioactiveSubstance> { new ProtonParticle(), new Mercury176() } },
            { 0.49d, new List<RadioactiveSubstance> { new AlphaParticle(8894047.4), new Gold173() } },

        };
    }
}
    
    