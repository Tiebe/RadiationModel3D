
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten177 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten177";
        public override double halfLife { get; } = 7944.0d;
        public override double atomicWeight { get; } = 176.94664d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum177() } },

        };
    }
}
    
    