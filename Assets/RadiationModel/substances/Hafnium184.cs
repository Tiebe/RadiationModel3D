
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium184";
        public override double halfLife { get; } = 14832.0d;
        public override double atomicWeight { get; } = 183.95545d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum184() } },

        };
    }
}
    
    