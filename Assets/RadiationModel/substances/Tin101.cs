
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin101 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin101";
        public override double halfLife { get; } = 2.22d;
        public override double atomicWeight { get; } = 100.93525d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Indium101() } },

        };
    }
}
    
    