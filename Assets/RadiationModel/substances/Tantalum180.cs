using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum180 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum180";
        public override double halfLife { get; } = 29354.4d;
        public override double atomicWeight { get; } = 179.94747d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new List<RadioactiveSubstance> { new Hafnium180() } },
            { 0.15d, new List<RadioactiveSubstance> { new BetaParticle(-1, 702600.0), new Tungsten180() } },

        };
    }
}
    
    