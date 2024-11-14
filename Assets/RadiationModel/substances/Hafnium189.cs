using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium189";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 188.97085d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4810000.0), new Tantalum189() } },

        };
    }
}
    
    