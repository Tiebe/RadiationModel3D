
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum87 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum87";
        public override double halfLife { get; } = 14.1d;
        public override double atomicWeight { get; } = 86.9282d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium87() } },

        };
    }
}
    
    