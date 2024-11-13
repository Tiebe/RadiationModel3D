
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron8 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron8";
        public override double halfLife { get; } = 0.7719d;
        public override double atomicWeight { get; } = 8.02461d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Beryllium8() } },

        };
    }
}
    
    