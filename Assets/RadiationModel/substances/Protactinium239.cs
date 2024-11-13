
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium239";
        public override double halfLife { get; } = 6480.0d;
        public override double atomicWeight { get; } = 239.05726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Uranium239() } },

        };
    }
}
    
    