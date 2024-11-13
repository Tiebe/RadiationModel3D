
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum190 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum190";
        public override double halfLife { get; } = 5.3d;
        public override double atomicWeight { get; } = 189.96917d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten190() } },

        };
    }
}
    
    