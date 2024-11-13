
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium45";
        public override double halfLife { get; } = 1068.0d;
        public override double atomicWeight { get; } = 44.96069d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium45() } },

        };
    }
}
    
    