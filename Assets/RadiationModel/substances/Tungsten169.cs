
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten169 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten169";
        public override double halfLife { get; } = 74.0d;
        public override double atomicWeight { get; } = 168.95178d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum169() } },

        };
    }
}
    
    