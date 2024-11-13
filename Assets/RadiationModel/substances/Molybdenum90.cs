
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum90 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum90";
        public override double halfLife { get; } = 20016.0d;
        public override double atomicWeight { get; } = 89.91393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium90() } },

        };
    }
}
    
    