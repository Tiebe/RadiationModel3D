
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium197";
        public override double halfLife { get; } = 10224.0d;
        public override double atomicWeight { get; } = 196.96956d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury197() } },

        };
    }
}
    
    