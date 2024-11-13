
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium198 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium198";
        public override double halfLife { get; } = 19080.0d;
        public override double atomicWeight { get; } = 197.97045d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury198() } },

        };
    }
}
    
    