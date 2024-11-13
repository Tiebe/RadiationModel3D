
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium124";
        public override double halfLife { get; } = 9.1d;
        public override double atomicWeight { get; } = 123.93031d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum124() } },

        };
    }
}
    
    