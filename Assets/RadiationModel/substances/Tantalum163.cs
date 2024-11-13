
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum163 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum163";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 162.95434d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium163() } },

        };
    }
}
    
    