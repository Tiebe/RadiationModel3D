
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium51";
        public override double halfLife { get; } = 0.365d;
        public override double atomicWeight { get; } = 50.97583d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium51() } },

        };
    }
}
    
    