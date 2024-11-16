using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium182m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium182m";
        public override double halfLife { get; } = 3690.0d;
        public override double atomicWeight { get; } = 181.95182d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.54d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1553700.0), new Tantalum182() } },
            { 0.46d, new List<RadioactiveSubstance> { new GammaParticle((1173000.0, 0.00106)), new Hafnium182() } },

        };
    }
}
    
    