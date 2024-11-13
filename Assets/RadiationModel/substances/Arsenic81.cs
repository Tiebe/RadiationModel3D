
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic81 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic81";
        public override double halfLife { get; } = 33.3d;
        public override double atomicWeight { get; } = 80.92213d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium81() } },

        };
    }
}
    
    