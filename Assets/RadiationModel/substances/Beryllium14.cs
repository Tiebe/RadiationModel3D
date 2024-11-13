
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium14 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium14";
        public override double halfLife { get; } = 0.00453d;
        public override double atomicWeight { get; } = 14.04289d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Boron14() } },

        };
    }
}
    
    