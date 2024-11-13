
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten174 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten174";
        public override double halfLife { get; } = 1992.0d;
        public override double atomicWeight { get; } = 173.94608d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum174() } },

        };
    }
}
    
    